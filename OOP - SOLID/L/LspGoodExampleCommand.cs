using OOP___SOLID.L.LSPGoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L
{
    public class LspGoodExampleCommand : IMenuCommand
    {
        public string Title => "LSP - ГАРНИЙ приклад (Дотримання принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  LSP - ГАРНИЙ ПРИКЛАД: Правильна підстановка підтипів      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПЕРЕВАГИ цього підходу:");
            Console.WriteLine("✓ BirdGood містить ТІЛЬКИ спільну поведінку всіх птахів:");
            Console.WriteLine("   • Eat() - всі птахи їдять");
            Console.WriteLine("   • MakeSound() - всі птахи видають звуки\n");

            Console.WriteLine("✓ Окремий інтерфейс IFlyable для літаючих птахів");
            Console.WriteLine("✓ Окремий інтерфейс ISwimmable для плаваючих птахів");
            Console.WriteLine("✓ Пінгвін та Страус НЕ мають методу Fly() - він їм не потрібен");
            Console.WriteLine("✓ Жодних NotSupportedException!");
            Console.WriteLine("✓ БУДЬ-ЯКУ птаху можна передати замість BirdGood");
            Console.WriteLine("✓ Дотримання LSP - підтипи коректно замінюють базовий тип");
            Console.WriteLine("✓ Поєднання з ISP - клієнти залежать тільки від потрібних методів\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ РОБОТИ:\n");

            // Всі птахи
            var allBirds = new List<BirdGood>
        {
            new SparrowGood { Name = "Сіренький" },
            new EagleGood { Name = "Орлик" },
            new ParrotGood { Name = "Кеша" },
            new PenguinGood { Name = "Пінгвінчик" },
            new OstrichGood { Name = "Страусик" },
            new KiwiGood { Name = "Ківі" }
        };

            var sanctuary = new BirdSanctuaryGood();

            // ✅ Годування працює для ВСІХ птахів
            sanctuary.FeedBirds(allBirds);

            Console.WriteLine("\n" + new string('═', 60));

            // ✅ Політ працює ТІЛЬКИ для літаючих птахів
            var flyingBirds = allBirds.OfType<IFlyable>().ToList();
            sanctuary.MakeFlyableBirdsFly(flyingBirds);

            Console.WriteLine(new string('═', 60));

            // ✅ Плавання працює ТІЛЬКИ для плаваючих птахів
            var swimmingBirds = allBirds.OfType<ISwimmable>().ToList();
            sanctuary.MakeSwimmableBirdsSwim(swimmingBirds);

            Console.WriteLine(new string('═', 60));

            // ✅ Демонстрація для різних типів птахів
            Console.WriteLine("\n🔍 ДЕТАЛЬНА ІНФОРМАЦІЯ ПРО КОЖНУ ПТАХУ:");

            sanctuary.ShowBirdInfo(new EagleGood { Name = "Беркут" });
            sanctuary.ShowBirdInfo(new PenguinGood { Name = "Антарктик" });
            sanctuary.ShowBirdInfo(new OstrichGood { Name = "Швидкий" });

            Console.WriteLine("\n\n✓ ✓ ✓ МАГІЯ LSP ✓ ✓ ✓");
            Console.WriteLine("💡 Принцип підстановки Лісков дотримано:");
            Console.WriteLine("   • Всі методи, які приймають BirdGood, працюють з УСІМА нащадками");
            Console.WriteLine("   • Немає неочікуваних винятків чи помилок");
            Console.WriteLine("   • Немає необхідності перевіряти конкретний тип птаха");
            Console.WriteLine("   • Базовий клас містить тільки справді спільну поведінку");
            Console.WriteLine("   • Специфічна поведінка винесена в окремі інтерфейси");
            Console.WriteLine("\n💡 Підтипи (Sparrow, Eagle, Penguin) можна безпечно підставити");
            Console.WriteLine("   замість базового типу (Bird) без порушення роботи програми!");
        }
    }
}
