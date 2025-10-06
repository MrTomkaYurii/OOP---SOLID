using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.D.DIPGoodExample
{
    // ✅ Сервіс залежить від АБСТРАКЦІЙ, а не від конкретних класів
    public class UserServiceGood
    {
        private readonly ILogger _logger;
        private readonly INotificationSender _notificationSender;
        private readonly IUserRepository _userRepository;

        // Dependency Injection через конструктор
        public UserServiceGood(
            ILogger logger,
            INotificationSender notificationSender,
            IUserRepository userRepository)
        {
            // Отримуємо залежності ззовні (DI)
            _logger = logger;
            _notificationSender = notificationSender;
            _userRepository = userRepository;
        }

        public void RegisterUser(string email, string name)
        {
            _logger.Log($"Початок реєстрації користувача: {email}");

            try
            {
                // Валідація
                if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    _logger.Log($"Помилка: невалідний email - {email}");
                    throw new ArgumentException("Невалідний email");
                }

                // Збереження в БД (не знаємо яка конкретно БД - це абстракція!)
                string userId = Guid.NewGuid().ToString().Substring(0, 8);
                _userRepository.Save(userId, $"Name: {name}, Email: {email}");

                // Відправка повідомлення (не знаємо як саме - це абстракція!)
                _notificationSender.Send(
                    email,
                    "Ласкаво просимо!",
                    $"Вітаємо, {name}! Ваш акаунт створено."
                );

                _logger.Log($"Користувач {email} успішно зареєстрований");
            }
            catch (Exception ex)
            {
                _logger.Log($"Критична помилка: {ex.Message}");
                throw;
            }
        }

        // ✅ Можна легко змінити БД, спосіб логування чи відправки без зміни цього класу
        // ✅ Легко тестувати - можна передати mock-об'єкти через конструктор
        // ✅ UserServiceGood НЕ залежить від деталей реалізації
    }
}
