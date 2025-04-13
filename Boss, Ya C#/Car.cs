using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public struct Car : ITransport
    {
        public readonly string GetTransportType() => "Автомобиль";
        public decimal RentalCostPerMinute { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public override readonly string ToString() => $"Марка: {Make}, Модель: {Model}, Гос. номер: {LicensePlate}, Цвет: {Color}";
    }
}
