﻿using OOP___SOLID.I.ISPGoodExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.I.ISPGoodExample
{
    // ✅ Робот реалізує ТІЛЬКИ те, що він може робити (без їжі та зарплати!)
    public class RobotWorkerGood : IWorkable, IShiftWorker
    {
        private string _model;

        public RobotWorkerGood(string model)
        {
            _model = model;
        }

        // IWorkable
        public void Work()
        {
            Console.WriteLine($"[Робот {_model}] 🤖 Виконую заводські операції...");
        }

        // IShiftWorker
        public void WorkNightShift()
        {
            Console.WriteLine($"[Робот {_model}] 🌙 Працюю цілу ніч без втоми");
        }

        public void WorkWeekends()
        {
            Console.WriteLine($"[Робот {_model}] 📅 Працюю 24/7 включно з вихідними");
        }

        // ✅ Немає методів для їжі, кави, зарплати - робот їх не потребує!
    }

}
