using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L.LSPBadExample
{
    // ❌ Страус теж НЕ літає
    public class OstrichBad : BirdBad
    {
        public override void Eat()
        {
            Console.WriteLine($"[{Name}] 🦤 Страус їсть рослини та комах");
        }

        public override void Fly()
        {
            // ❌ Страуси не літають!
            throw new NotSupportedException($"{Name} - страус не вміє літати!");
        }
    }
}
