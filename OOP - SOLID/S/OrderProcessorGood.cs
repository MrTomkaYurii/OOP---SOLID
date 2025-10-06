using OOP___SOLID.S.SRPGoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.S
{
    // 8. Координатор (Orchestrator) - відповідає ЛИШЕ за координацію процесу
    // Він не робить роботу сам, а делегує її спеціалізованим класам
    public class OrderProcessorGood
    {
        private readonly OrderValidator _validator;
        private readonly DiscountCalculator _discountCalculator;
        private readonly OrderRepository _repository;
        private readonly EmailService _emailService;
        private readonly ReportGenerator _reportGenerator;
        private readonly Logger _logger;

        public OrderProcessorGood()
        {
            // Dependency Injection - отримуємо залежності ззовні
            _validator = new OrderValidator();
            _discountCalculator = new DiscountCalculator();
            _repository = new OrderRepository();
            _emailService = new EmailService();
            _reportGenerator = new ReportGenerator();
            _logger = new Logger();
        }

        public void ProcessOrder(string customerEmail, List<string> items, decimal totalPrice)
        {
            try
            {
                // Створюємо замовлення
                var order = new Order
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 8),
                    CustomerEmail = customerEmail,
                    Items = items,
                    TotalPrice = totalPrice,
                    CreatedAt = DateTime.Now
                };

                // Кожна операція виконується окремим класом
                _validator.Validate(order);
                order.Discount = _discountCalculator.Calculate(order.TotalPrice);
                _repository.Save(order);
                _emailService.SendOrderConfirmation(order);
                _reportGenerator.GeneratePdfReport(order);
                _logger.Log($"Замовлення №{order.Id} успішно оброблено");

                Console.WriteLine("\n✓ ✓ ✓ ЗАМОВЛЕННЯ УСПІШНО ОБРОБЛЕНО ✓ ✓ ✓");
            }
            catch (Exception ex)
            {
                _logger.Log($"Помилка: {ex.Message}");
                throw;
            }
        }
    }
}
