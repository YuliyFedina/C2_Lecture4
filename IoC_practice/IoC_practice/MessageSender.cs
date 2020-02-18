using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace IoC_practice
{
    public class MessageSender
    {
        private readonly IMessageRepository _messageRepository;

        public MessageSender(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void SendMessages()
        {
            foreach (var message in _messageRepository.GetAll())
            {
                try
                {
                    SendMessage(message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Не удалось отправить сообщение :(");
                }
            }
        }

        private void SendMessage(Message message)
        {
            var mailMessage = new MailMessage();
            const string reciever = "reciever@gmail.com";
            mailMessage.To.Add(reciever);
            mailMessage.Subject = message.Title;
            mailMessage.From = new MailAddress("sender@gmail.com");
            mailMessage.Body = message.Text;

            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
                //smtp.Send(mailMessage);
                Console.WriteLine("Сообщение '{0}' успешно отправлено получателю!", message.Title);
            }
        }
    }
}