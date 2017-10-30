using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentKindsOfClasses
{
    /// <summary>
    /// Sealed class for Player.
    /// Sealed type of a class was chosen to prevent inheritence of this class.
    /// </summary>
    public sealed class Player : Character
    {
        // Int value for Experience Points. Allows to follow the player's progress in the game.
        private int _experiencePoints;

        // Encapsulated field for exp points.
        public int ExperiencePoints { get => _experiencePoints; set => _experiencePoints = value; }

        /// <summary>
        /// Nested class for player stats.
        /// Allows to add stats to a playable characters. Can be used in game as modificators.
        /// </summary>
        public class TalentStats
        {
            // Field for strength that might be used as an attack modifier.
            private int _strength;
            // Field for perception that might be used as a ranged attack modifier.
            private int _perception;
            // Field for endurance that might be used for hit points mofifying.
            private int _endurance;
            // Field for charisma that might be used in dialogues.
            private int _charisma;
            // Field for intelligence that used in dialogues.
            private int _intelligence;
            // Field for agility that usually is used for attack dodging.
            private int _agility;

            // Encapsulated fields
            public int Strength { get => _strength; set => _strength = value; }
            public int Perception { get => _perception; set => _perception = value; }
            public int Endurance { get => _endurance; set => _endurance = value; }
            public int Charisma { get => _charisma; set => _charisma = value; }
            public int Intelligence { get => _intelligence; set => _intelligence = value; }
            public int Agility { get => _agility; set => _agility = value; }
        }

        // Constructor for the class. In a start we indicate name, hp, armor and level for the player.
        public Player(string name, double hitPoints, int armor, int level)
        {
            Name = name;
            HitPoints = hitPoints;
            Armor = armor;
            Level = level;
        }
        
        // Picks up an item. Might throw an exception if the amount of items is higher than 10.
        public void PickUpItem(List<string> inventory, string item)
        {
            if (inventory.Count < 10)
                inventory.Add(item);
            else if (inventory.Count >= 10)
                throw new Exception();
        }
    }

}
