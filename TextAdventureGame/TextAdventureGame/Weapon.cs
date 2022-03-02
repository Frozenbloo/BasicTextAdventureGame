using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    internal class Weapon : Item
    {
        /// <summary>
        /// Allows damage to enemies and items
        /// </summary>
        public int Damage { get; set; }
        public Weapon(string name, string description, int damage) : base(name, description)
        {
            Damage = damage;
        }
    }
}
