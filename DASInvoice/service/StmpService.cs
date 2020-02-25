using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DASInvoice.service
{
    class StmpService
    {
        const String SMTP_HOST = "smtp.mailgun.org";
        const int SMTP_PORT = 587;
        const String SMTP_USERNAME = "postmaster@mail.hetrickportal.com";
        const String SMTP_PASSWORD = "53c08ecbb2648bbe1592c69294c5a163-4167c382-f799cedf";

        public static Boolean Send(String from, String to, String subject, String body)
        {
            if (!Util.IsValidEmail(to))
            {
                MessageBox.Show("Your Email address is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MailMessage message = new MailMessage(from, to);
            message.BodyEncoding = Encoding.UTF8;
            message.SubjectEncoding = Encoding.UTF8;
            message.Subject = subject;
            message.Body = body;
            SmtpClient client = new SmtpClient(SMTP_HOST, SMTP_PORT);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
            client.Send(message);
            return true;
        }
    }
}
