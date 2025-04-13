using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public class Manager : IPayDay, IConsolePrintable
    {
        private string? fullName { get; set; }
        private int workingDays { get; set; }

        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }

        public int WorkingDays
        {
            get => workingDays;
            set => workingDays = value;
        }


        public double CalculateSalary()
        {
            return workingDays * 1000;
        }

        public void Print()
        {
            Console.WriteLine($"Менеджер: {FullName}, Отработал: {WorkingDays}, заработал: {CalculateSalary()}\n" +
                $"Проходной налог: {Accounting.Tax(this):F2}\n" +
                $"После вычета налога: {CalculateSalary() - Accounting.Tax(this)}");
        }

    }
}
