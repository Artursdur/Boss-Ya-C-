using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public interface IWeapon
    {
        string WeaponType();
        int WeaponPower { get; }
        string SpecialAbility { get; }

    }
}
