using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public class Necessites : ITax, IConsolePrintable
    {
        public static string RuClassName { get; } = "Предмет первой необходимисти";

        private string productName;
        private double productCost;

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public double ProductCost
        {
            get => productCost;
            set => productCost = value;
        }

        public double AddTax()
        {
            return productCost * 1.005;
        }

        public void Print()
        {
            Console.WriteLine($"Класс: {RuClassName}\n" +
                $"Название товара: {ProductName}\n" +
                $"Стоимость без налога: {ProductCost:F2}\n" +
                $"Стоимость с налогом: {AddTax():F2}");
        }
    }
}
