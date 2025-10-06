using OOP___SOLID;
using OOP___SOLID.O;
using OOP___SOLID.S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var menu = new MainMenu();
            menu.Run();
        }
    }

    #region Menu System - Демонстрація OCP через розширювану систему меню

    // Головне меню - легко розширюється новими командами без зміни коду
    public class MainMenu
    {
        private readonly List<IMenuCommand> _commands;

        public MainMenu()
        {
            // Додавання нових пунктів меню не вимагає зміни логіки MainMenu (OCP)
            _commands = new List<IMenuCommand>
            {
                new SrpBadExampleCommand(),
                new SrpGoodExampleCommand(),
                new OcpBadExampleCommand(),
                new OcpGoodExampleCommand(),
                new ExitCommand()
            };
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║     ДЕМОНСТРАЦІЯ SOLID ПРИНЦИПІВ                           ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

                for (int i = 0; i < _commands.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_commands[i].Title}");
                }

                Console.Write("\nВиберіть опцію: ");
                if (int.TryParse(Console.ReadLine(), out int choice) &&
                    choice > 0 && choice <= _commands.Count)
                {
                    Console.Clear();
                    _commands[choice - 1].Execute();

                    if (_commands[choice - 1] is ExitCommand)
                        break;

                    Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                    Console.ReadKey();
                }
            }
        }
    }

    #endregion

    #region Exit Command

    public class ExitCommand : IMenuCommand
    {
        public string Title => "Вихід";

        public void Execute()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            Дякуємо за використання програми!                     ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  Пам'ятайте всі SOLID принципи:                                  ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  S - Single Responsibility Principle                             ║");
            Console.WriteLine("║      (Принцип єдиної відповідальності)                           ║");
            Console.WriteLine("║      → Один клас = одна причина для зміни                        ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  O - Open/Closed Principle                                       ║");
            Console.WriteLine("║      (Принцип відкритості/закритості)                            ║");
            Console.WriteLine("║      → Відкрито для розширення, закрито для модифікації          ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  L - Liskov Substitution Principle                               ║");
            Console.WriteLine("║      (Принцип підстановки Барбари Лісков)                        ║");
            Console.WriteLine("║      → Нащадки повинні замінювати батьківські класи              ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  I - Interface Segregation Principle                             ║");
            Console.WriteLine("║      (Принцип розділення інтерфейсів)                            ║");
            Console.WriteLine("║      → Багато специфічних інтерфейсів краще за один великий      ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("║  D - Dependency Inversion Principle                              ║");
            Console.WriteLine("║      (Принцип інверсії залежностей)                              ║");
            Console.WriteLine("║      → Залежність від абстракцій, а не від конкретних класів    ║");
            Console.WriteLine("║                                                                  ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝\n");
        }
    }

    #endregion
}