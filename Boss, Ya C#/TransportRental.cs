using BossYaCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public class TransportRental<T>(string clientFullName, T transport, int rentalTimeMinutes) where T : ITransport
    {
        public string ClientFullName { get; set; } = clientFullName;
        public T Transport { get; set; } = transport;
        public int RentalTimeMinutes { get; set; } = rentalTimeMinutes;

        public string GetRentalInfo()
        {
            return $"ФИО клиента: {ClientFullName}\n" +
                   $"Вид транспорта: {Transport.GetTransportType()}\n" +
                   $"Транспорт: {Transport}\n" +
                   $"Время аренды (минут): {RentalTimeMinutes}\n" +
                   $"Стоимость аренды за минуту: {Transport.RentalCostPerMinute}";
        }

        public decimal CalculateTotalCost()
        {
            return RentalTimeMinutes * Transport.RentalCostPerMinute;
        }
    }
}
