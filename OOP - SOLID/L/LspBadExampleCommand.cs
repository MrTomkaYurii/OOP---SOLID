using OOP___SOLID.L.LSPBadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L
{
    public class LspBadExampleCommand : IMenuCommand
    {
        public string Title => "LSP - ПОГАНИЙ приклад (Порушення принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  LSP - ПОГАНИЙ ПРИКЛАД: Порушення принципу підстановки     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПРОБЛЕМИ цього підходу:");
            Console.WriteLine("❌ Базовий клас BirdBad має метод Fly()");
            Console.WriteLine("❌ Але НЕ всі птахи літають (пінгвін, страус)");
            Console.WriteLine("❌ Пінгвін та Страус змушені викидати NotSupportedException");
            Console.WriteLine("❌ Порушення LSP - не можна замінити BirdBad на PenguinBad");
            Console.WriteLine("❌ Код, який працює з BirdBad, ламається для нащадків");
            Console.WriteLine("❌ Потрібні перевірки типів або try-catch блоки\n");

            Console.WriteLine("❌ Принцип Лісков каже:");
            Console.WriteLine("   'Якщо S є підтипом T, то об'єкти типу T можуть бути");
            Console.WriteLine("    замінені об'єктами типу S без зміни властивостей програми'\n");
            Console.WriteLine("   У нашому випадку: Bird НЕ можна замінити на Penguin!");

            Console.WriteLine("\n" + new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ РОБОТИ:\n");

            var birds = new List<BirdBad>
        {
            new SparrowBad { Name = "Сіренький" },
            new EagleBad { Name = "Орлик" },
            new PenguinBad { Name = "Пінгвінчик" },
            new OstrichBad { Name = "Страусик" }
        };

            var sanctuary = new BirdSanctuaryBad();

            sanctuary.FeedBirds(birds);

            Console.WriteLine("\n" + new string('═', 60));
            sanctuary.MakeBirdsFly(birds);  // ❌ Тут виникнуть помилки!

            Console.WriteLine("\n\n💡 ПРОБЛЕМА:");
            Console.WriteLine("   Метод MakeBirdsFly очікує, що ВСІ птахи літають,");
            Console.WriteLine("   але Пінгвін та Страус порушують цю поведінку!");
            Console.WriteLine("   Це класичне порушення принципу підстановки Лісков (LSP)");
        }
    }
}
