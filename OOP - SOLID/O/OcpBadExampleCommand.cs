using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.O
{
    public class OcpBadExampleCommand : IMenuCommand
    {
        public string Title => "OCP - ПОГАНИЙ приклад (Порушення принципу)";

        public void Execute()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  OCP - ПОГАНИЙ ПРИКЛАД: Модифікація існуючого коду         ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("ПРОБЛЕМИ цього підходу:");
            Console.WriteLine("❌ Для додавання нового способу оплати треба:");
            Console.WriteLine("   • Модифікувати метод ProcessPayment (додати if)");
            Console.WriteLine("   • Модифікувати метод CalculateFee (додати if)");
            Console.WriteLine("   • Ризик зламати існуючий код");
            Console.WriteLine("   • Порушення принципу OCP\n");

            Console.WriteLine("❌ Важко тестувати - треба тестувати весь клас заново");
            Console.WriteLine("❌ Неможливо додати новий тип оплати без зміни коду");
            Console.WriteLine("❌ Метод ProcessPayment стає все більшим і складнішим");
            Console.WriteLine("❌ Порушення SRP - метод робить занадто багато\n");

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("ДЕМОНСТРАЦІЯ РОБОТИ:\n");

            var processor = new PaymentProcessorBad();

            Console.WriteLine("1. Оплата кредитною карткою:");
            processor.ProcessPayment("CreditCard", 500m);
            Console.WriteLine($"   Комісія: {processor.CalculateFee("CreditCard", 500m)} грн\n");

            Console.WriteLine("2. Оплата через PayPal:");
            processor.ProcessPayment("PayPal", 300m);
            Console.WriteLine($"   Комісія: {processor.CalculateFee("PayPal", 300m)} грн\n");

            Console.WriteLine("3. Оплата криптовалютою:");
            processor.ProcessPayment("Crypto", 1000m);
            Console.WriteLine($"   Комісія: {processor.CalculateFee("Crypto", 1000m)} грн\n");

            Console.WriteLine("❌ Уявіть, що нам треба додати Google Pay, Apple Pay, банківський переказ...");
            Console.WriteLine("   Метод ProcessPayment перетвориться на монстра з десятками if-else!");
        }
    }
}
