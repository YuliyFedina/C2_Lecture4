using System.Collections.Generic;

namespace IoC_practice.Repository
{
    public class MessageRepository2 : IMessageRepository
    {
        private readonly List<Message> _messages;

        public MessageRepository2()
        {
            _messages = new List<Message>();
        }

        public void Add(Message newMessage)
        {
            _messages.Add(newMessage);
        }

        public void Delete(Message deleteMessage)
        {
            _messages.Remove(deleteMessage);
        }

        public void DeleteAll()
        {
            _messages.Clear();
        }

        public IList<Message> GetAll()
        {
           return _messages;
        }
    }
}