using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public struct Car1
    {
        public string VinNumEngine { get; set;  }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int Year { get; set; }

        public readonly string Info
        {
            get {
                return $"Марка: {Brand}\n" +
                    $"Модель: {Model}\n" +
                    $"Цвет: {Color}\n" +
                    $"VIN номер: {VinNumEngine}\n" +
                    $"Год выпуска: {Year}\n";
                }
        }

        public readonly bool CheckVIN(string vin)
        {
            return vin == VinNumEngine;
        }
    }
}
