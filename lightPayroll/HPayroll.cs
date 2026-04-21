using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lighPayrollUI
{
    internal class HPayroll
    {
        public PayrollInput ShowPayrollForm()
        {
            Form form = new Form()
            {
                Width = 400,
                Height = 350,
                Text = "Payroll Input",
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                BackColor = Color.Beige,
                ControlBox = false
            };

            // Controls
            NumericUpDown hours = CreateNumeric("Hours Worked");
            NumericUpDown rate = CreateNumeric("Hourly Rate");
            NumericUpDown otHours = CreateNumeric("Overtime Hours");
            NumericUpDown otRate = CreateNumeric("Overtime Rate");
            NumericUpDown deductions = CreateNumeric("Deductions");



           

            Button ok = new Button() { Text = "OK", Width = 100 };
            Button cancel = new Button() { Text = "Cancel", Width = 100 };

            PayrollInput result = null;

            ok.Click += (s, e) =>
            {
                result = new PayrollInput()
                {
                    HourlyRate = rate.Value,
                    OtherDeductions = deductions.Value, //Other Deductions (Loans, Cash Advance, etc.)
                };
                
                form.Close();
            };

            cancel.Click += (s, e) =>
            {
                result = null;
                form.Close();
            };

            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(10),
                AutoScroll = true
            };

            panel.Controls.Add(hours);
            panel.Controls.Add(rate);
            panel.Controls.Add(otHours);
            panel.Controls.Add(otRate);
            panel.Controls.Add(deductions);


            Panel buttons = new Panel() { Height = 40, Dock = DockStyle.Bottom };
            ok.Left = 50;
            cancel.Left = 200;
            buttons.Controls.Add(ok);
            buttons.Controls.Add(cancel);

            form.Controls.Add(panel);
            form.Controls.Add(buttons);

            form.ShowDialog();

            return result;
        }

        // Helper method
        private NumericUpDown CreateNumeric(string labelText)
        {
            Panel container = new Panel() { Width = 340, Height = 50 };

            Label label = new Label()
            {
                Text = labelText,
                Dock = DockStyle.Top
            };

            NumericUpDown num = new NumericUpDown()
            {
                Dock = DockStyle.Bottom,
                DecimalPlaces = 2,
                Maximum = 1000000,
                Minimum = 0,
                ThousandsSeparator = true
            };

            container.Controls.Add(label);
            container.Controls.Add(num);

            // Trick: return NumericUpDown but keep label visually attached
            num.Tag = container;

            return num;
        }
    }
}
