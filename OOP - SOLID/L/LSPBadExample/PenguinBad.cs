using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L.LSPBadExample
{
    // ❌ Пінгвін НЕ літає - порушення LSP!
    public class PenguinBad : BirdBad
    {
        public override void Eat()
        {
            Console.WriteLine($"[{Name}] 🐧 Пінгвін їсть рибу");
        }

        public override void Fly()
        {
            // ❌ Пінгвіни не літають! Змушені викидати виключення
            throw new NotSupportedException($"{Name} - пінгвін не вміє літати!");
        }
    }
}
