using System.Net;
using System.Net.Mail;

namespace Company.Service.Helper;

public static class EmailSettings
{
        public static void SendEmail(Email input)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("shehab.mkk2004@gmail.com", "ulqfsautynnpqkzn");
            client.Send("shehab.mkk2004@gmail.com", input.To , input.Subject , input.Body);
        }
}