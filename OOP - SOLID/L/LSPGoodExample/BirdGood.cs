using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.L.LSPGoodExample
{
    // Базовий клас для всіх птахів (тільки спільна поведінка)
    public abstract class BirdGood
    {
        public string Name { get; set; }

        // Всі птахи їдять - це спільна поведінка
        public abstract void Eat();

        // Всі птахи видають звуки
        public abstract void MakeSound();
    }
}
