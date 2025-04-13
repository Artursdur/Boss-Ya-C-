using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public static class Accounting
    {
        
        public static double Tax(IPayDay a) => a.CalculateSalary() * 0.13;
        
    }
}
