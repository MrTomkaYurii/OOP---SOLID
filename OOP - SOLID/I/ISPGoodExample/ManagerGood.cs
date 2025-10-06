using OOP___SOLID.I.ISPGoodExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I.ISPGoodExample
{
    // ✅ Менеджер реалізує свій набір інтерфейсів
    public class ManagerGood : IWorkable, IManager, IOfficeWorker, IComputerUser, IEatable, ISalaried
    {
        private string _name;

        public ManagerGood(string name)
        {
            _name = name;
        }

        // IWorkable
        public void Work()
        {
            Console.WriteLine($"[{_name}] 👔 Керую проектом...");
        }

        // IManager
        public void ManageTeam()
        {
            Console.WriteLine($"[{_name}] 👥 Провожу daily stand-up з командою");
        }

        public void ConductPerformanceReview()
        {
            Console.WriteLine($"[{_name}] 📊 Оцінюю продуктивність співробітників");
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"[{_name}] 💵 Затверджую бюджет на квартал");
        }

        // IOfficeWorker
        public void AttendMeeting()
        {
            Console.WriteLine($"[{_name}] 📅 Беру участь у планерці");
        }

        public void SendEmail()
        {
            Console.WriteLine($"[{_name}] 📧 Відправляю звіти керівництву");
        }

        // IComputerUser
        public void UseComputer()
        {
            Console.WriteLine($"[{_name}] 💻 Переглядаю аналітику в Excel");
        }

        // IEatable
        public void EatLunch()
        {
            Console.WriteLine($"[{_name}] 🍽️ Обідаю в бізнес-центрі");
        }

        public void TakeCoffeeBreak()
        {
            Console.WriteLine($"[{_name}] ☕ Неформальна зустріч за кавою");
        }

        // ISalaried
        public void ReceiveSalary()
        {
            Console.WriteLine($"[{_name}] 💰 Отримую менеджерську зарплату");
        }
    }

}
