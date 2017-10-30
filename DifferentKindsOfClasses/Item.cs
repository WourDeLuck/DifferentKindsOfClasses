using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentKindsOfClasses
{
    /// <summary>
    /// Abstract item class. Contains "name" field.
    /// </summary>
    public abstract class Item
    {
        // Field for item name.
        private string _name;

        // Encapsulated field.
        public string Name { get => _name; set => _name = value; }
    }

    /// <summary>
    /// Weapon class is a child class of Item. 
    /// </summary>
    public class Weapon : Item
    {
        // Field for indicating weapon damage.
        private int _weaponDamage;

        // Encapsulated field.
        public int WeaponDamage { get => _weaponDamage; set => _weaponDamage = value; }

        // Constructor.
        public Weapon(string name, int damage)
        {
            Name = name;
            WeaponDamage = damage;
        }
    }

    /// <summary>
    /// Medkit class is a child of Item.
    /// </summary>
    public class Medkit : Item
    {
        // Field for indicating HP that the medkits restores.
        private int _hpToRestore;

        // Encapsulated field.
        public int HpToRestore { get => _hpToRestore; set => _hpToRestore = value; }

        // Constructor.
        public Medkit(string name, int restoreHP)
        {
            Name = name;
            HpToRestore = restoreHP;
        }
    }

    /// <summary>
    /// Armor class is a child of Item.
    /// </summary>
    public class Armor : Item
    {
        // Determines amount of armor to restore.
        private int armorToRestore;

        // Encapsulated field.
        public int ArmorToRestore { get => armorToRestore; set => armorToRestore = value; }

        // Constructor.
        public Armor(string name, int restoreArmor)
        {
            Name = name;
            ArmorToRestore = restoreArmor;
        }
    }

}
