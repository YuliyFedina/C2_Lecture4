using System;
using IoC_practice.Repository;
using Microsoft.Practices.Unity;

namespace IoC_practice
{
    class Program
    {   //Создать вторую реализацию репозитория:
        //регистрировать и резолвить по имени.

        private static UnityContainer _unityContainer;
        static void Main(string[] args)
        {
            InitializeModule();
            
            var repository = _unityContainer.Resolve<IMessageRepository>("firstRepository");
            var repository2 = _unityContainer.Resolve<IMessageRepository>("secondRepository");

            var formHandler = new FormHandler(repository);
            formHandler.AddNewMessage("Очень важное сообщение", "Важно!");
            formHandler.SendAllMessages();

            var formHandler2 = new FormHandler(repository2);
            formHandler2.AddNewMessage("Очень важное сообщение2", "Важно2!");
            formHandler2.SendAllMessages();

            Console.ReadLine();
        }

        private static void InitializeModule()
        {
            _unityContainer = new UnityContainer();
            _unityContainer.RegisterType<IMessageRepository, MessageRepository>("firstRepository", new InjectionConstructor());
            _unityContainer.RegisterType<IMessageRepository, MessageRepository2>("secondRepository", new InjectionConstructor());
        }
    }
}
