using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossYaCsharp
{
    public class CharacterInGame<T>(string name, string race, T weapon, int characterStrength) where T : IWeapon
    {
        public string Name { get; set; } = name;
        public string Race { get; set; } = race;
        public T Weapon { get; set; } = weapon;
        public int CharacterStrength { get; set; } = characterStrength;

        
        public string GetCharacterInfo()
        {

            string weaponInfo = $"Оружие: {Weapon.WeaponType()}\n" +
                               $"Сила оружия: {Weapon.WeaponPower}\n" +
                               $"Особые возможности: {Weapon.SpecialAbility}\n";

            if (Weapon is Sword sword)
            {
                weaponInfo += $"Качество меча: {sword.Quality}";
            }
            else if (Weapon is Bow bow)
            {
                weaponInfo += $"Дальность лука: {bow.Range}\n" +
                              $"Точность лука: {bow.Accuracy}";
            }

            return $"Имя персонажа: {Name}\n" +
                   $"Раса персонажа: {Race}\n" +
                   $"Сила персонажа: {CharacterStrength}\n" +
                   weaponInfo;
        }

        public int GetPower()
        {
            return CharacterStrength + Weapon.WeaponPower;
        }

    }
}
