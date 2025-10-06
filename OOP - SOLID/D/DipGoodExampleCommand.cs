using OOP___SOLID.D.DIPGoodExample;
using OOP___SOLID.D.DIPGoodExample.Loggers;
using OOP___SOLID.D.DIPGoodExample.Notifications;
using OOP___SOLID.D.DIPGoodExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.D
{
    public class DipGoodExampleCommand : IMenuCommand
    {
        public string Title => "DIP - ГАРНИЙ приклад (Дотримання принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  DIP - ГАРНИЙ ПРИКЛАД: Залежність від абстракцій           ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПЕРЕВАГИ цього підходу:");
            Console.WriteLine("✓ UserServiceGood залежить від ІНТЕРФЕЙСІВ (абстракцій):");
            Console.WriteLine("   • ILogger (можна підставити будь-яку реалізацію)");
            Console.WriteLine("   • INotificationSender (email, SMS, push)");
            Console.WriteLine("   • IUserRepository (MySQL, PostgreSQL, MongoDB)\n");

            Console.WriteLine("✓ Залежності передаються через конструктор (Dependency Injection)");
            Console.WriteLine("✓ Можна легко замінити реалізацію без зміни UserServiceGood");
            Console.WriteLine("✓ Легко тестувати - можна передати mock-об'єкти");
            Console.WriteLine("✓ Дотримання DIP - модулі залежать від абстракцій");
            Console.WriteLine("✓ Модулі високого рівня НЕ залежать від низького рівня\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 1: MySQL + Email + FileLogger\n");

            var service1 = new UserServiceGood(
                new FileLoggerImpl(),
                new SmtpNotificationSender(),
                new MySqlUserRepository()
            );
            service1.RegisterUser("user1@example.com", "Олександр");

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 2: PostgreSQL + SMS + ConsoleLogger\n");

            var service2 = new UserServiceGood(
                new ConsoleLoggerImpl(),
                new SmsNotificationSender(),
                new PostgresUserRepository()
            );
            service2.RegisterUser("user2@example.com", "Марія");

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 3: MongoDB + Push + DatabaseLogger\n");

            var service3 = new UserServiceGood(
                new DatabaseLoggerImpl(),
                new PushNotificationSender(),
                new MongoUserRepository()
            );
            service3.RegisterUser("user3@example.com", "Тарас");

            Console.WriteLine("\n\n✓ ✓ ✓ МАГІЯ DIP ✓ ✓ ✓");
            Console.WriteLine("💡 Один і той самий UserServiceGood працює з:");
            Console.WriteLine("   • 3 різними базами даних");
            Console.WriteLine("   • 3 різними способами логування");
            Console.WriteLine("   • 3 різними каналами повідомлень");
            Console.WriteLine("   І все це БЕЗ жодних змін у класі UserServiceGood!");
            Console.WriteLine("\n💡 Тепер легко додати Redis, Kafka, Telegram-бота - просто");
            Console.WriteLine("   створити нову реалізацію інтерфейсу!");
        }
    }
}
