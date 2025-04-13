using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public struct Sword : IWeapon
    {
        public readonly string WeaponType() => "Меч";
        public int WeaponPower { get; set; }
        public string SpecialAbility { get; set; }
        public SwordQuality Quality { get; set; }

        public enum SwordQuality
        {
            Обычное,
            Хорошее,
            Уникальное
        }
    }
}
