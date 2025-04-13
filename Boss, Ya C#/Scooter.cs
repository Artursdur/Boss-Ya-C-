using BossYaCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public struct Scooter : ITransport
    {
        public readonly string GetTransportType() => "Самокат";
        public decimal RentalCostPerMinute { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override readonly string ToString() => $"Модель: {Model}, Год выпуска: {Year}";
    }
}