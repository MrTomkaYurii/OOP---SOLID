using OOP___SOLID.I.ISPGoodExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I.ISPGoodExample
{
    // ✅ Інтерн - вчиться, кодить, але поки без зарплати
    public class InternGood : IWorkable, IDeveloper, IComputerUser, IEatable
    {
        private string _name;

        public InternGood(string name)
        {
            _name = name;
        }

        public void Work()
        {
            Console.WriteLine($"[{_name}] 📚 Вчуся та допомагаю команді...");
        }

        public void WriteCode()
        {
            Console.WriteLine($"[{_name}] 🆕 Пишу простий код під наглядом ментора");
        }

        public void ReviewCode()
        {
            Console.WriteLine($"[{_name}] 👁️ Вивчаю код досвідчених розробників");
        }

        public void DebugCode()
        {
            Console.WriteLine($"[{_name}] 🐞 Виправляю дрібні баги для практики");
        }

        public void UseComputer()
        {
            Console.WriteLine($"[{_name}] 💻 Користуюсь робочим ноутбуком");
        }

        public void EatLunch()
        {
            Console.WriteLine($"[{_name}] 🥪 Обідаю разом з командою");
        }

        public void TakeCoffeeBreak()
        {
            Console.WriteLine($"[{_name}] ☕ Спілкуюсь з колегами за кавою");
        }

        // ✅ Немає ISalaried - інтерн працює безкоштовно або за стипендію!
    }
}
