using OOP___SOLID.I.ISPGoodExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I.ISPGoodExample
{
    // ✅ Фрілансер - працює, кодить, отримує оплату, але без офісу
    public class FreelancerGood : IWorkable, IDeveloper, ISalaried
    {
        private string _name;

        public FreelancerGood(string name)
        {
            _name = name;
        }

        public void Work()
        {
            Console.WriteLine($"[{_name}] 🏠 Працюю з дому...");
        }

        public void WriteCode()
        {
            Console.WriteLine($"[{_name}] 💻 Пишу код для клієнта з США");
        }

        public void ReviewCode()
        {
            Console.WriteLine($"[{_name}] 👀 Переглядаю код віддаленої команди");
        }

        public void DebugCode()
        {
            Console.WriteLine($"[{_name}] 🔧 Фіксю баги через TeamViewer");
        }

        public void ReceiveSalary()
        {
            Console.WriteLine($"[{_name}] 💵 Отримую оплату через PayPal");
        }

        // ✅ Немає офісних методів - фрілансер працює віддалено!
    }
}
