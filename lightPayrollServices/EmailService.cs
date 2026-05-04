using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Sockets;
using lightPayrollServices.Properties;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;    

namespace lightPayrollServices
{
    public class EmailService 
    {

        private static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public static void SendPayrollEmail(string toEmail, string employeeName)
        {
            var emailUser = Environment.GetEnvironmentVariable("EMAIL_USER");
            var emailPassword = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");

            if (string.IsNullOrEmpty(emailUser) || string.IsNullOrEmpty(emailPassword))
            {
                throw new Exception("Email credentials are not set in environment variables.");
            }

            try
            {
                var message = new MimeMessage();

                // Gmail sender
                message.From.Add(new MailboxAddress("Light Payroll", emailUser));
                message.To.Add(new MailboxAddress(employeeName, toEmail));

                message.Subject = "Payslip Notification";

                var builder = new BodyBuilder();

                // convert resource image to bytes
                var imageBytes = ImageToByteArray(Properties.Resources.companyLogo);

                // attach image properly
                var image = builder.LinkedResources.Add("companyLogo.png", imageBytes);
                image.ContentId = "companyLogo";

                builder.HtmlBody = $@"
                <html>
                <body style='margin:0; padding:0; background-color:#f5f0e6; font-family:Arial; color:#000000;'>

                    <div style='background-color:#f5f0e6; padding:20px;'>

                        <div style='max-width:500px; margin:auto; background-color:#ffffff; border-radius:10px; overflow:hidden;'>

                            <!-- HEADER LOGO -->
                           <img src='cid:companyLogo' style='width:180px; display:block; margin:0 auto; padding:20px 0;' />

                            <div style='padding:20px; background-color:#ffffff; color:#000000;'>

                                <p style='color:#000000;'>Hello {employeeName},</p>

                                <p style='color:#000000;'>
                                    Your payslip is now available to view.
                                </p>

                                <div style='background-color:#f5eadb; padding:15px; text-align:center; border-radius:8px; margin:20px 0;'>
                                    <b style='color:#000000;'>Thank You!</b>
                                </div>

                            </div>

                        </div>

                    </div>

                </body>
                </html>";

                // IMPORTANT: use builder
                message.Body = builder.ToMessageBody();

                using var client = new SmtpClient();

                // IMPORTANT: Gmail SMTP settings
                client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                // IMPORTANT: USE GMAIL APP PASSWORD (NOT your Gmail password)
                client.Authenticate(emailUser, emailPassword);

                client.Send(message);
                client.Disconnect(true);
            }
            catch (SocketException)
            {
                throw new Exception("Failed to connect to the internet.");
            }

        }
    }
}