using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.D.DIPBadExample
{
    // ❌ Клас прямо залежить від конкретних реалізацій
    public class UserServiceBad
    {
        // Жорстка залежність від конкретних класів
        private FileLogger _logger;
        private SmtpEmailSender _emailSender;
        private MySqlDatabase _database;

        public UserServiceBad()
        {
            // Створюємо залежності всередині класу (погано!)
            _logger = new FileLogger();
            _emailSender = new SmtpEmailSender();
            _database = new MySqlDatabase();
        }

        public void RegisterUser(string email, string name)
        {
            _logger.LogToFile($"Початок реєстрації користувача: {email}");

            try
            {
                // Валідація
                if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    _logger.LogToFile($"Помилка: невалідний email - {email}");
                    throw new ArgumentException("Невалідний email");
                }

                // Збереження в БД
                string userId = Guid.NewGuid().ToString().Substring(0, 8);
                _database.SaveToMySQL(userId, $"Name: {name}, Email: {email}");

                // Відправка email
                _emailSender.SendEmailViaSMTP(
                    email,
                    "Ласкаво просимо!",
                    $"Вітаємо, {name}! Ваш акаунт створено."
                );

                _logger.LogToFile($"Користувач {email} успішно зареєстрований");
            }
            catch (Exception ex)
            {
                _logger.LogToFile($"Критична помилка: {ex.Message}");
                throw;
            }
        }

        // ❌ Якщо треба змінити БД з MySQL на PostgreSQL - доведеться міняти цей клас
        // ❌ Якщо треба логувати в БД замість файлу - доведеться міняти цей клас
        // ❌ Неможливо протестувати без реальних файлів, SMTP, MySQL
    }

}
