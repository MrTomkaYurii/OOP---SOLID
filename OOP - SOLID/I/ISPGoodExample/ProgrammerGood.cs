using OOP___SOLID.I.ISPGoodExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I.ISPGoodExample
{
    // ✅ Програміст реалізує ТІЛЬКИ ті інтерфейси, які йому потрібні
    public class ProgrammerGood : IWorkable, IDeveloper, IComputerUser, IEatable, ISalaried
    {
        private string _name;

        public ProgrammerGood(string name)
        {
            _name = name;
        }

        // IWorkable
        public void Work()
        {
            Console.WriteLine($"[{_name}] 💻 Працюю над проектом...");
        }

        // IDeveloper
        public void WriteCode()
        {
            Console.WriteLine($"[{_name}] ⌨️ Пишу код на C#...");
        }

        public void ReviewCode()
        {
            Console.WriteLine($"[{_name}] 🔍 Переглядаю pull request колеги...");
        }

        public void DebugCode()
        {
            Console.WriteLine($"[{_name}] 🐛 Виправляю баги в продакшені...");
        }

        // IComputerUser
        public void UseComputer()
        {
            Console.WriteLine($"[{_name}] 🖥️ Використовую потужний ноутбук");
        }

        // IEatable
        public void EatLunch()
        {
            Console.WriteLine($"[{_name}] 🍕 Замовляю піцу на обід");
        }

        public void TakeCoffeeBreak()
        {
            Console.WriteLine($"[{_name}] ☕ Беру каву та релаксую");
        }

        // ISalaried
        public void ReceiveSalary()
        {
            Console.WriteLine($"[{_name}] 💰 Отримую зарплату на картку");
        }
    }

}
