using OOP___SOLID.I.ISPGoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I
{
    public class IspGoodExampleCommand : IMenuCommand
    {
        public string Title => "ISP - ГАРНИЙ приклад (Дотримання принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  ISP - ГАРНИЙ ПРИКЛАД: Розділені специфічні інтерфейси     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПЕРЕВАГИ цього підходу:");
            Console.WriteLine("✓ Замість одного великого інтерфейсу - 8 маленьких:");
            Console.WriteLine("   • IWorkable, IComputerUser, IOfficeWorker");
            Console.WriteLine("   • IEatable, ISalaried, IManager");
            Console.WriteLine("   • IDeveloper, IShiftWorker\n");

            Console.WriteLine("✓ Кожен клас реалізує ТІЛЬКИ потрібні йому інтерфейси");
            Console.WriteLine("✓ Програміст НЕ реалізує методи менеджера");
            Console.WriteLine("✓ Робот НЕ реалізує методи для їжі та зарплати");
            Console.WriteLine("✓ Фрілансер НЕ реалізує офісні методи");
            Console.WriteLine("✓ Інтерн НЕ реалізує методи для зарплати");
            Console.WriteLine("✓ Жодних NotImplementedException!");
            Console.WriteLine("✓ Легко додавати нові типи працівників");
            Console.WriteLine("✓ Дотримання ISP - клієнти не залежать від непотрібних методів\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 1: Програміст\n");

            var programmer = new ProgrammerGood("Іван");
            programmer.Work();
            programmer.WriteCode();
            programmer.DebugCode();
            programmer.UseComputer();
            programmer.EatLunch();
            programmer.TakeCoffeeBreak();
            programmer.ReceiveSalary();

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 2: Менеджер\n");

            var manager = new ManagerGood("Олена");
            manager.Work();
            manager.ManageTeam();
            manager.ConductPerformanceReview();
            manager.ApproveBudget();
            manager.AttendMeeting();
            manager.SendEmail();
            manager.EatLunch();
            manager.ReceiveSalary();

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 3: Робот (БЕЗ їжі та зарплати)\n");

            var robot = new RobotWorkerGood("T-800");
            robot.Work();
            robot.WorkNightShift();
            robot.WorkWeekends();
            // ✅ У робота немає методів EatLunch(), ReceiveSalary() - вони йому не потрібні!

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 4: Фрілансер (БЕЗ офісних методів)\n");

            var freelancer = new FreelancerGood("Максим");
            freelancer.Work();
            freelancer.WriteCode();
            freelancer.ReviewCode();
            freelancer.ReceiveSalary();
            // ✅ У фрілансера немає AttendMeeting(), SendEmail() - він працює віддалено!

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ 5: Інтерн (БЕЗ зарплати)\n");

            var intern = new InternGood("Анна");
            intern.Work();
            intern.WriteCode();
            intern.ReviewCode();
            intern.UseComputer();
            intern.EatLunch();
            intern.TakeCoffeeBreak();
            // ✅ У інтерна немає ReceiveSalary() - він ще не на зарплаті!

            Console.WriteLine("\n\n✓ ✓ ✓ МАГІЯ ISP ✓ ✓ ✓");
            Console.WriteLine("💡 Кожен тип працівника реалізує ТІЛЬКИ те, що йому потрібно:");
            Console.WriteLine("   • Програміст: кодування + комп'ютер + їжа + зарплата");
            Console.WriteLine("   • Менеджер: управління + офіс + їжа + зарплата");
            Console.WriteLine("   • Робот: робота + змінний графік (БЕЗ їжі та зарплати)");
            Console.WriteLine("   • Фрілансер: кодування + зарплата (БЕЗ офісу)");
            Console.WriteLine("   • Інтерн: кодування + їжа (БЕЗ зарплати)");
            Console.WriteLine("\n💡 Жодного класу не змушено реалізовувати непотрібні методи!");
            Console.WriteLine("   Це і є принцип розділення інтерфейсів (ISP)!");
        }
    }
}
