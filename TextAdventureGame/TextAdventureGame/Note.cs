using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    /// <summary>
    /// Allows the player to read things, like maps and clues
    /// </summary>
    class Note : Item
    {
        public string Message { get; set; }
        public Note(string name, string description, string message) : base(name, description)
        {
            Message = message;
        }
    }
}
