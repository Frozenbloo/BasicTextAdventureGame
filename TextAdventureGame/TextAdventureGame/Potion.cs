using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    internal class Potion : Item
    {
        /// <summary>
        /// If Healing is +ive, then Player.Health +=
        /// If Healing is -ive, then Player.Health -=
        /// </summary>
        public int Healing { get; set; }
        public Potion(string name, string description, int healing) : base(name, description)
        {
            Healing = healing;
        }
    }
}
