using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public struct Employee
    {
        public string Name {  get; set; }
        public string SecondName {  get; set; }
        public string ThirdName {  get; set; }

        public string Post {  get; set; }

        public int Year { get; set; }

        private static int correctYear = 2025;

        
        public readonly string Info
        {
            get
            {
                return $"ФИО: {SecondName} {Name} {ThirdName}\n" +
                    $"Должность: {Post}\n" +
                    $"Принят на работу: {Year}\n" +
                    $"Отработал: {Experience(Year)} лет";
            }
        }
        public static int Experience(int d)
        {
            return correctYear - d;
        }

    }
}
