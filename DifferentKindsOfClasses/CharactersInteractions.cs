using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentKindsOfClasses
{
    /// <summary>
    /// Static class for character interactions.
    /// Contains methods for health restoring, experience adding and level upping
    /// </summary>
    public static class CharactersInteractions
    {
        /// <summary>
        /// Restores hp with medkits.
        /// </summary>
        /// <param name="hp">Character's hp.</param>
        /// <returns></returns>
        public static double RestoreHP(double hp)
        {
            hp = hp + 25;
            return hp;
        }

        /// <summary>
        /// Adds experience to the current one.
        /// </summary>
        /// <param name="exp">Player's experience</param>
        /// <returns></returns>
        public static int AddExperience(int exp)
        {
            exp =+ 100;
            return exp;
        }

        /// <summary>
        /// Counts player's level depending on experience points.
        /// </summary>
        /// <param name="level">Player's level.</param>
        /// <param name="exp">Player's experience.</param>
        /// <returns></returns>
        public static int LevelUp(int level, int exp)
        {
            if (exp % 1000 == 0)
                level = exp / 1000;
            return level;
        }
    }
}
