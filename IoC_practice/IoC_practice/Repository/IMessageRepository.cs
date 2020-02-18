using System.Collections.Generic;

namespace IoC_practice.Repository
{
    public interface IMessageRepository
    {
        IList<Message> GetAll();
        void Add(Message newMessage);
        void Delete(Message deleteMessage);
        void DeleteAll();
    }
}
