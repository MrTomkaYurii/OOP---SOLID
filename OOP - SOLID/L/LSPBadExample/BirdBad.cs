using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L.LSPBadExample
{
    // Базовий клас для птахів
    public abstract class BirdBad
    {
        public string Name { get; set; }

        public abstract void Eat();
        public abstract void Fly();  // ❌ Не всі птахи літають!
    }
}
