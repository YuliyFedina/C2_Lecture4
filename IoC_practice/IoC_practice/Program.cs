using System;

namespace IoC_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // InitializeModule();

            var messageRepository = new MessageRepository();

            var formHandler = new FormHandler(messageRepository);
            formHandler.AddNewMessage("Очень важное сообщение", "Важно!");
            formHandler.SendAllMessages();

            Console.ReadLine();
        }

        private static void InitializeModule()
        {
            throw new NotImplementedException();
        }
    }
}
