using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentKindsOfClasses
{
    /// <summary>
    /// Class for enemy.
    /// </summary>
    public class Enemy : Character
    {
        // Defines enemy type (monster, marine, etc.)
        private string _enemyType;

        // Encapsulated field
        public string EnemyType { get => _enemyType; set => _enemyType = value; }

        public Enemy(string name, double hp, int armor, int level, string enemyType)
        {
            Name = name;
            HitPoints = hp;
            Armor = armor;
            Level = level;
            EnemyType = enemyType;
        }
    }
}
