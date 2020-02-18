using System;

namespace IoC_practice
{
    class FormHandler
    {
        private readonly MessageRepository _repository;

        public FormHandler(MessageRepository repository)
        {
            _repository = repository;
        }

        public void SendAllMessages()
        {
            var sender = new MessageSender(_repository);
            sender.SendMessages();

            _repository.DeleteAll();
        }

        public void AddNewMessage(string text, string title)
        {
            if (text.Length > 200)
            {
                Console.WriteLine("Cообщение слишком длинное, длина сообщения не должна превышать 200 символов.");
                return;
            }

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Заголовок сообщения не может быть пустым.");
                return;
            }

            _repository.Add(new Message { Text = text, Title = title });


        }
    }
}
