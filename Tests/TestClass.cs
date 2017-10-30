using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DifferentKindsOfClasses;

namespace Tests
{
    [TestClass]
    public class TestClass
    {
        Player playa = new Player("Bdoba", 100, 80, 2);

        [TestMethod]
        public void CreatePlayer()
        {
            Player player = new Player("Bdoba", 100, 80, 2);
            player.EquippedWeapon = "Sniper Rifle";

            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void CreateEnemy()
        {
            Enemy enemy = new Enemy("Barnacle", 100, 5, 1, "monster");

            Assert.IsNotNull(enemy);
        }

        [TestMethod]
        public void DamageEnemy()
        {
            Weapon wep = new Weapon("Riffle", 50);
            playa.EquippedWeapon = wep.ToString();

            Enemy enemy2 = new Enemy("Solja", 50, 30, 10, "Monster");

            var test = playa.CauseDamage(wep.WeaponDamage, enemy2.HitPoints, enemy2.Armor);

            Assert.IsTrue(test < 50);
        }

        [TestMethod]
        public void AddItemsToPlayerInventory()
        {
            playa.Inventory.Add("apple");
            playa.Inventory.Add("pistol");
            playa.Inventory.Add("sniper rifle");

            Assert.IsTrue(playa.Inventory.Contains("apple"));
        }

        [TestMethod]
        public void PickUpItem()
        {
            Medkit small = new Medkit("small medkit", 5);
            playa.PickUpItem(playa.Inventory, small.ToString());

            Assert.IsNotNull(playa.Inventory);
        }

        [TestMethod]
        public void RestoreHP()
        {
            Enemy enemy = new Enemy("Zupa Marine", 50, 20, 5, "marine");

            var restoreTest = CharactersInteractions.RestoreHP(enemy.HitPoints);

            Assert.AreEqual(75, restoreTest);
        }

        [TestMethod]
        public void AddingExperience()
        {
            var expTest = CharactersInteractions.AddExperience(playa.ExperiencePoints);

            Assert.IsNotNull(expTest);
        }

        [TestMethod]
        public void LevelUp()
        {
            var levelUp = CharactersInteractions.LevelUp(0, 1000);

            Assert.AreEqual(1, levelUp);
        }
    }
}
