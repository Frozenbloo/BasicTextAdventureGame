using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Location
    {


        #region Public Properties
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string LocationToNorth { get; set; }
        public string LocationToEast { get; set; }
        public string LocationToSouth { get; set; }
        public string LocationToWest { get; set; }
        public Dictionary<string, Item> Items { get; set; } = new Dictionary<string, Item>();
        public Item ItemRequired { get; set; }

        public string ImageLocation { get; set; }
        #endregion

        #region Constructor
        public Location(string name,
            string displayname,
            string description,
            string locationtoNorth = "",
            string locationtoEast = "",
            string locationtoSouth = "",
            string locationtoWest = "",
            string imageLocation = "",
            List<Item> listitem = null,
            Item itemRequired = null)
        {
            Name = name;
            DisplayName = displayname;
            Description = description;
            LocationToNorth = locationtoNorth;
            LocationToEast = locationtoEast;
            LocationToSouth = locationtoSouth;
            LocationToWest = locationtoWest;
            if (listitem != null)
                CreateDictionary(listitem);
            ItemRequired = itemRequired;
            ImageLocation = imageLocation;
        }
        #endregion
        #region Methods
        private void CreateDictionary(List<Item> itemlist)
        {
            foreach (Item item in itemlist)
            {
                Items.Add(item.Name, item);
            }
        }
        public void AddItem(Item item)
        {
            Items.Add(item.Name, item);
        }
        public void RemoveItem(Item item)
        {
            Items.Remove(item.Name);
        }
        public void RemoveItem(string itemName)
        {
            Items.Remove(itemName);
        }
        #endregion
    }
}
