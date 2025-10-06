using OOP___SOLID.I.ISPBadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I
{
    public class IspBadExampleCommand : IMenuCommand
    {
        public string Title => "ISP - ПОГАНИЙ приклад (Порушення принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  ISP - ПОГАНИЙ ПРИКЛАД: Один великий інтерфейс             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПРОБЛЕМИ цього підходу:");
            Console.WriteLine("❌ Інтерфейс IWorkerBad містить 15 методів для всіх типів працівників");
            Console.WriteLine("❌ Програміст змушений реалізувати методи менеджера");
            Console.WriteLine("❌ Робот змушений реалізувати методи для їжі та зарплати");
            Console.WriteLine("❌ Більшість методів викидають NotImplementedException");
            Console.WriteLine("❌ Порушення ISP - клієнти залежать від методів, які не використовують");
            Console.WriteLine("❌ Важко підтримувати - один великий інтерфейс");
            Console.WriteLine("❌ Додавання нового методу ламає ВСІ існуючі класи\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ РОБОТИ:\n");

            var programmer = new ProgrammerBad("Іван");
            var robot = new RobotWorkerBad("T-800");

            Console.WriteLine("Програміст виконує свої завдання:");
            Console.WriteLine(new string('═', 60));
            programmer.Work();
            programmer.WriteCode();
            programmer.DebugCode();
            programmer.EatLunch();

            Console.WriteLine("\n❌ Спроба викликати непотрібні методи для програміста:");
            try
            {
                programmer.ManageTeam();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"   ПОМИЛКА: {ex.Message}");
            }

            try
            {
                programmer.ApproveBudget();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"   ПОМИЛКА: {ex.Message}");
            }

            Console.WriteLine("\n\nРобот виконує свої завдання:");
            Console.WriteLine(new string('═', 60));
            robot.Work();
            robot.WorkNightShift();
            robot.WorkWeekends();

            Console.WriteLine("\n❌ Спроба викликати непотрібні методи для робота:");
            try
            {
                robot.EatLunch();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"   ПОМИЛКА: {ex.Message}");
            }

            try
            {
                robot.ReceiveSalary();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"   ПОМИЛКА: {ex.Message}");
            }

            try
            {
                robot.WriteCode();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"   ПОМИЛКА: {ex.Message}");
            }

            Console.WriteLine("\n\n💡 ПРОБЛЕМА: Класи залежать від методів, які їм не потрібні!");
            Console.WriteLine("   Це порушує принцип розділення інтерфейсів (ISP)");
        }
    }
}
