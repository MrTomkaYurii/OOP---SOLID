using OOP___SOLID.D.DIPBadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.D
{
    public class DipBadExampleCommand : IMenuCommand
    {
        public string Title => "DIP - ПОГАНИЙ приклад (Порушення принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  DIP - ПОГАНИЙ ПРИКЛАД: Залежність від конкретних класів   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПРОБЛЕМИ цього підходу:");
            Console.WriteLine("❌ UserServiceBad прямо залежить від конкретних класів:");
            Console.WriteLine("   • FileLogger (не можна змінити спосіб логування)");
            Console.WriteLine("   • SmtpEmailSender (не можна використати інший сервіс)");
            Console.WriteLine("   • MySqlDatabase (жорстко прив'язані до MySQL)\n");

            Console.WriteLine("❌ Залежності створюються всередині класу (new FileLogger())");
            Console.WriteLine("❌ Неможливо замінити залежності без зміни коду");
            Console.WriteLine("❌ Важко тестувати - потрібні реальні файли, SMTP, БД");
            Console.WriteLine("❌ Якщо треба PostgreSQL замість MySQL - треба міняти UserServiceBad");
            Console.WriteLine("❌ Модулі високого рівня залежать від модулів низького рівня");
            Console.WriteLine("❌ Порушення DIP - немає абстракцій між рівнями\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ РОБОТИ:\n");

            var userService = new UserServiceBad();

            Console.WriteLine("Спроба 1: Реєстрація валідного користувача");
            Console.WriteLine(new string('═', 60));
            userService.RegisterUser("ivan@example.com", "Іван Петренко");

            Console.WriteLine("\n\nСпроба 2: Реєстрація з невалідним email");
            Console.WriteLine(new string('═', 60));
            try
            {
                userService.RegisterUser("invalid-email", "Тест");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ПОМИЛКА] {ex.Message}");
            }

            Console.WriteLine("\n\n💡 ПРОБЛЕМА: Якщо завтра нам треба:");
            Console.WriteLine("   • Логувати в базу даних замість файлу");
            Console.WriteLine("   • Використовувати SendGrid замість SMTP");
            Console.WriteLine("   • Перейти на PostgreSQL замість MySQL");
            Console.WriteLine("   → Доведеться ПЕРЕПИСУВАТИ UserServiceBad!");
        }
    }
}
