using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_practice
{
    public interface IMessageRepository
    {
        IList<Message> GetAll();
        void Add(Message newMessage);
        void Delete(Message deleteMessage);
        void DeleteAll();
    }
}
