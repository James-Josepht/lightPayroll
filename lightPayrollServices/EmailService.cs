using MailKit.Net.Smtp;
using MimeKit;

namespace lightPayrollInfrastructure
{
    public class EmailService
    {
        public static void SendPayrollEmail(string toEmail, string employeeName, decimal netPay)
        {
            var message = new MimeMessage();

            // Gmail sender
            message.From.Add(new MailboxAddress("Payroll System", "yourgmail@gmail.com"));
            message.To.Add(new MailboxAddress(employeeName, toEmail));

            message.Subject = "Payroll Notification";

            message.Body = new TextPart("plain")
            {
                Text =
                $@"Hello {employeeName},

                Your payroll has been processed successfully.

                Net Pay: ₱{netPay:N2}

                Thank you."
            };

            using var client = new SmtpClient();

            // IMPORTANT: Gmail SMTP settings
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

            // IMPORTANT: USE APP PASSWORD (NOT your Gmail password)
            client.Authenticate("jjcabilan1@gmail.com", "dzck ixlx rgkt wmtn");

            client.Send(message);
            client.Disconnect(true);
        }
    }
}