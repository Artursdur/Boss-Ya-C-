using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public interface IPayDay
    {
        double CalculateSalary();

        string FullName { get; set; }
        int WorkingDays { get; set; }
    }
}
