using System.Collections.Generic;

namespace IoC_practice
{
    public class MessageRepository : IMessageRepository
    {
        private readonly List<Message> _messages; 

        public MessageRepository()
        {
            _messages = new List<Message>();
        }

        public IList<Message> GetAll()
        {
            return _messages;
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
    }
}
