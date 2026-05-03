using lightPayrollModel;
using lightPayrollServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lighPayrollUI
{
    internal class HPayroll
    {
        public Payroll ShowPayrollForm(int employeeID, int accountantID)
        {
            PayrollService service = new PayrollService();

            Form form = new Form()
            {
                Width = 420,
                Height = 320,
                Text = "Payroll Input",
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                BackColor = Color.Beige,
                ControlBox = false
            };

            // MAIN GRID DESIGN
            TableLayoutPanel panel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 9,
                Padding = new Padding(15),
            };

            DateTimePicker periodStart = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Fill
            };

            DateTimePicker periodEnd = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Fill
            };

            DateTimePicker payrollDate = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Fill
            };


            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            // CONTROLS
            NumericUpDown rate = CreateNumeric();
            NumericUpDown pagIbig = CreateNumeric();
            NumericUpDown deductions = CreateNumeric();

            panel.Controls.Add(new Label() { Text = "Hourly Rate", AutoSize = true }, 0, 0);
            panel.Controls.Add(rate, 1, 0);

            panel.Controls.Add(new Label() { Text = "Pag-IBIG", AutoSize = true }, 0, 1);
            panel.Controls.Add(pagIbig, 1, 1);

            panel.Controls.Add(new Label() { Text = "Other Deductions", AutoSize = true }, 0, 2);
            panel.Controls.Add(deductions, 1, 2);

            panel.Controls.Add(new Label() { Text = "Period Start", AutoSize = true }, 0, 3);
            panel.Controls.Add(periodStart, 1, 3);

            panel.Controls.Add(new Label() { Text = "Period End", AutoSize = true }, 0, 4);
            panel.Controls.Add(periodEnd, 1, 4);

            panel.Controls.Add(new Label() { Text = "Payroll Date", AutoSize = true }, 0, 5);
            panel.Controls.Add(payrollDate, 1, 5);


            // BUTTONS
            Button ok = new Button() { Text = "OK", Width = 100 };
            Button cancel = new Button() { Text = "Cancel", Width = 100 };
            DateTime start = periodStart.Value;
            DateTime end = periodEnd.Value;
            DateTime payDate = payrollDate.Value;

            if (periodEnd.Value < periodStart.Value)
            {
                throw new Exception("Period End cannot be earlier than Period Start.");
            }

            Panel buttons = new Panel()
            {
                Height = 50,
                Dock = DockStyle.Bottom
            };

            ok.Left = 90;
            cancel.Left = 220;

            buttons.Controls.Add(ok);
            buttons.Controls.Add(cancel);

            form.Controls.Add(panel);
            form.Controls.Add(buttons);

            Payroll result = null;

           

            //decimal overtimeHours = totalHours > 160 ? totalHours - 160 : 0;
            //for period type


            // OK CLICK
            ok.Click += (s, e) =>
            {
              
                decimal hoursWorked = PayrollService.GetTotalHours(employeeID);

                // temporary only
                decimal overtimeHours = hoursWorked > 8 ? hoursWorked - 8 : 0;

                Payroll payroll = service.CalculateSecond(
                    employeeID,
                    rate.Value,
                    hoursWorked,
                    overtimeHours,
                    pagIbig.Value,        
                    deductions.Value,     
                    processedBy: accountantID,
                    periodStart.Value,
                    periodEnd.Value,
                    payrollDate.Value
                );
                

                result = payroll;
                form.Close();
            };

            cancel.Click += (s, e) =>
            {
                result = null;
                form.Close();
            };

            form.ShowDialog();
            return result;
        }

        private NumericUpDown CreateNumeric()
        {
            return new NumericUpDown()
            {
                DecimalPlaces = 2,
                Maximum = 1000000,
                Minimum = 0,
                Dock = DockStyle.Fill,
                ThousandsSeparator = true
            };
        }
    }
}