using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentKindsOfClasses
{
    /// <summary>
    /// Abstract class for in-game characters.
    /// Contains basic fields to describe a character.
    /// The class was divided into two.
    /// </summary>
    public abstract partial class Character
    {
        // Field for indicating character's name.
        private string name;
        // Field for indicating character's hp.
        private double _hitPoints;
        // Field for indicating character's armor.
        private int _armor;
        // Field for indicating character's equipped weapon.
        private string _equippedWeapon;
        // Amount of items in the invetory of the character.
        private List<string> _inventory = new List<string>();
        // Field for indicating the level of the character.
        private int _level;

        // Encapsulated fields.
        public string Name { get => name; set => name = value; }
        public double HitPoints { get => _hitPoints; set => _hitPoints = value; }
        public int Armor { get => _armor; set => _armor = value; }
        public string EquippedWeapon { get => _equippedWeapon; set => _equippedWeapon = value; }
        public List<string> Inventory { get => _inventory; }
        public int Level { get => _level; set => _level = value; }
    }

    /// <summary>
    /// This part of the class contains the methods used within this class.
    /// </summary>
    public abstract partial class Character
    {
        /// <summary>
        /// Method counts the damage that character causes. Depends on the weapon damage and amount of armor.
        /// If weapon damage is 10 or more, enemy's armor is blocking 5 damage.
        /// If weapon damage is less than 10, the damage is being halved.
        /// </summary>
        /// <param name="weaponDamage">A parameter for weapon damage.</param>
        /// <param name="enemyHP">A parameter for enemy's hp.</param>
        /// <param name="enemyArmor">A parameter for enemy's armor.</param>
        /// <returns></returns>
        public double CauseDamage(int weaponDamage, double enemyHP, int enemyArmor)
        {
            if (enemyArmor > 0)
            {
                if (weaponDamage >= 10)
                {
                    enemyArmor -= 5;
                    enemyHP -= (weaponDamage - 5);
                }
                else 
                {
                    weaponDamage = weaponDamage / 2;
                    enemyHP -= weaponDamage;
                    enemyArmor -= weaponDamage;
                }
            }
            else if (enemyArmor <= 0)
                enemyHP -= weaponDamage;
            return enemyHP;
        }

        /// <summary>
        /// Changes the primary weapon.
        /// </summary>
        /// <param name="equippedWeapon"></param>
        /// <param name="inventory"></param>
        /// <param name="weapon"></param>
        public void ChangeWeapon(string equippedWeapon, List<string> inventory, string weapon)
        {
            inventory.Remove(weapon);
            inventory.Add(equippedWeapon);
            equippedWeapon = weapon;
        }
    }
}

