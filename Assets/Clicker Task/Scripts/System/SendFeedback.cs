using System.Collections;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using TMPro;

namespace ClickerTestTask
{
    public class SendFeedback : MonoBehaviour
    {
        [SerializeField, Tooltip("Пароль от почты")]
        private const string emailPassword = "123";

        [SerializeField]
        private TextMeshProUGUI messageText;

        [SerializeField]
        private TextMeshProUGUI emailGuestText;


        public void SendMessage()
        {
            MailMessage message = new MailMessage();

            message.Body = messageText.text.ToString();
            message.From = new MailAddress("Clicker@gmail.com");
            message.To.Add(emailGuestText.text.ToString());
            message.BodyEncoding = System.Text.Encoding.UTF8;

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Host = "smpt.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(message.From.Address, emailPassword);
            smtpClient.EnableSsl = true;

            ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };

            smtpClient.Send(message);
        }
    }
}
