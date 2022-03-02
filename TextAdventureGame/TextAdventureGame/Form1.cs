using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventureGame
{
    public partial class Form1 : Form
    {
        #region Class Variables
        private Location currentLocation;
        private string NorthExit;
        private string EastExit;
        private string SouthExit;
        private string WestExit;
        //Location Dictionary
        private Dictionary<string, Location> dictLocation = new Dictionary<string, Location>();
        //Item Dictionary
        private Dictionary<string, Item> dictItems = new Dictionary<string, Item>();
        #endregion
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e) { CreateGame(); }
        private void BtnDrop_Click(object sender, EventArgs e) { DropItem(); }
        private void BtnNorth_Click(object sender, EventArgs e) { Go("north"); }
        private void BtnEast_Click(object sender, EventArgs e) { Go("east"); }
        private void BtnSouth_Click(object sender, EventArgs e) { Go("south"); }
        private void BtnWest_Click(object sender, EventArgs e) { Go("west"); }
        private void BtnExamine_Click(object sender, EventArgs e) { ExamineItem(lstLocation); }
        private void BtnTake_Click(object sender, EventArgs e) { TakeItem(); }
        private void BtnHold_Click(object sender, EventArgs e) { HoldItem(); }
        private void BtnReturn_Click(object sender, EventArgs e) { ReturnItem(); }
        private void BtnUse_Click(object sender, EventArgs e) { UseItem(); }
        private void BtnExamineInventory_Click(object sender, EventArgs e) { ExamineItem(lstInventory); }
        #endregion

        private void CreateGame()
        {
            #region Items
            //Create 4 Items
            dictItems.Add("torch", new Item("torch", "a flaming wooden torch. It probably shouldn't be used in this adventure..."));
            dictItems.Add("LED torch", new Item("LED torch", "a new-fangled battery powered monstrosity"));
            dictItems.Add("iron key", new Item("iron key", "a rusty old key suitable for a dungeon door"));
            dictItems.Add("hotel card", new Item("hotel card", "a plastic key card with a magnetic strip. Probably not much use in a dungeon"));
            //SubClass Items
            dictItems.Add("knife", new Weapon("knife", "a poor quality kitchen knife from the Pound Shop", 100));
            dictItems.Add("aspirin", new Potion("aspirin", "a tablet useful after a late night...", 100));
            dictItems.Add("note", new Note("note", "a hotel provided acrylic plaque", "Welcome to the adventure! Don't forget the hotel key card before you leave"));
            #endregion

            #region Map
            /*
            
            World Plan:
                                    0 = bedroom
            |---|---|---|---|       1 = coridoor
            | 0   1   2 | 9 |       2 = lift
            |---|- -|---|   |       3 = hallway
                | 3 |||||   |       4 = diner
            |---|- -|||||     10    5 = store
            | 5   4 |||||   |       6 = bar
            |---|- -|---|   |       7 = games
                | 6   7     |       8 = wc
                |---|- -|---|       9 = reception
                | 8 |               10 = home
                |---|

            create 11 locations in a dictionary
            ******************************************************************************
            *These could be read from a text file, so many different games can be created*
            ******************************************************************************
            
            */
            dictLocation.Add("bedroom", new Location("bedroom", "a hotel room",
                                                                "smelling of stale cigarettes (the room not you..)",
                                                                "", "coridoor", "", "",
                                                                new List<Item> { dictItems["torch"], dictItems["hotel card"] },
                                                                dictItems["hotel card"]));

            dictLocation.Add("coridoor", new Location("coriddor",
                                            "a coridoor",
                                            "a dimly lit passage with a stained carpet",
                                            "", "lift", "hallway", "bedroom"));

            dictLocation.Add("lift",    new Location("lift",
                                            "a lift",
                                            "a dangerous structure with a hand-operated sliding door",
                                            "", "", "", "coridoor"));

            dictLocation.Add("hallway", new Location("hallway",
                                            "a hallway",
                                            "a narrow area with peeling wallpaper",
                                            "coridoor", "", "diner", ""));

            dictLocation.Add("diner", new Location("diner",
                                            "the dining room",
                                            "a large room filled with plastic tables and chairs",
                                            "hallway", "", "bar", "store"));

            dictLocation.Add("store", new Location("store",
                                            "a store-room",
                                            "a broom cupboard filled with junk",
                                            "", "diner", "", "",
                                            new List<Item> { dictItems["knife"], dictItems["iron key"] }));

            dictLocation.Add("bar", new Location("bar",
                                        "'The Snug Bar'",
                                        "very classy, even has sawdust on the floor",
                                        "diner", "games", "", ""));

            dictLocation.Add("games", new Location("games",
                                          "the games lounge",
                                          "a flickering light illumintates the moth-eaten sofas",
                                          "", "reception", "wc", "bar"));

            dictLocation.Add("wc", new Location("wc",
                                       "the toilets",
                                       "a shared facility in worse condition than found at Glastonbury",
                                       "games", "", "", ""));

            dictLocation.Add("reception", new Location("reception",
                                              "the recpetion area",
                                              "a delightful receptionist states: Computer says 'No'",
                                              "", "home", "", "games"));

            dictLocation.Add("home", new Location("home",
                                         "your bed at home",
                                         "in a cold sweat, after a bad dream...",
                                         "", "", "", ""));
            #endregion

            #region Player
            //Player init
            Player.Name = "Inksaver"; //Change for Form Later
            Player.Health = 100;
            Player.Strength = 50;
            Player.AddToInventory(dictItems["aspirin"]);
            Player.GetItemFromInventory(dictItems["note"]);
            currentLocation = dictLocation["bedroom"];
            #endregion

            Intro();
            Play();
        }

        private void Intro()
        {
            lblGame.Text = "Welcome to the worst adventure game you have ever played.\n" +
                "You have a serious hangover and you have no idea where you are.\n\n" +
                "Check you inventory. Anything in your sweaty hand?\n\n" +
                "Take a look around and see what you can do...\n";
        }

        private void Play()
        {
            //fill description
            DisplayStory($"You are in {currentLocation.DisplayName}, {currentLocation.Description}", true);
            this.Text = $"{currentLocation.DisplayName} - {currentLocation.Description}";
            NorthExit = currentLocation.LocationToNorth;
            EastExit = currentLocation.LocationToEast;
            SouthExit = currentLocation.LocationToSouth;
            WestExit = currentLocation.LocationToWest;
            DisplayItemList();
            DisplayInventory();
            DisplayCompass();
            DisplayHand();
        }

        private void DisplayStory(string AddText, bool clear = false)
        {
            if (clear)
            {
                lblGame.Text = string.Empty;
            }
            lblGame.Text += AddText;
        }

        private void DisplayItemList()
        {
            lblLocationItems.Text = "Items in " + currentLocation.DisplayName;
            lstLocation.Items.Clear();
            btnExamine.Enabled = false;
            btnTake.Enabled = false;
            if (currentLocation.Items.Count > 0)
            {
                foreach (KeyValuePair<string, Item> item in currentLocation.Items)
                {
                    lstLocation.Items.Add(item.Value.Name);
                }
                btnExamine.Enabled = true;
                btnTake.Enabled = true;
            }
        }

        private void DisplayInventory()
        {
            lstInventory.Items.Clear();
            if (Player.Inventory.Count > 0)
            {
                foreach (KeyValuePair<string,Item> item in Player.Inventory)
                {
                    lstInventory.Items.Add(item.Value.Name);
                }
            }
        }

        private void DisplayCompass()
        {
            DisableButton(btnNorth);
            DisableButton(btnEast);
            DisableButton(btnSouth);
            DisableButton(btnWest);
            if (NorthExit != "") { EnableButton(btnNorth); }
            if (EastExit != "") { EnableButton(btnEast); }
            if (SouthExit != "") { EnableButton(btnSouth); }
            if (WestExit != "") { EnableButton(btnWest); }
        }

        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.LightGray;
            button.ForeColor = Color.Gainsboro;
        }

        private void EnableButton(Button button)
        {
            button.Enabled = true;
            button.BackColor = Color.Green;
            button.ForeColor = Color.Black;
        }

        private void DisplayHand()
        {
            if (Player.ItemInHand != null)
            {
                lblHand.Text = Player.Name + " is holding: " + Player.ItemInHand.Name;
                btnDrop.Enabled = true;
                btnReturn.Enabled = true;
                btnUse.Enabled = true;
            }
            else
            {
                lblHand.Text = Player.Name + " is holding: air?";
                btnDrop.Enabled = false;
                btnReturn.Enabled = false;
                btnUse.Enabled = false;
            }
        }

        private void Go(string Direction)
        {
            Location checkLocation = currentLocation;
            switch (Direction)
            {
                case "north": CheckExit(dictLocation[NorthExit]);   break;
                case "east": CheckExit(dictLocation[EastExit]); break;
                case "south": CheckExit(dictLocation[SouthExit]); break;
                case "west": CheckExit(dictLocation[WestExit]); break;
            }
            if (checkLocation != currentLocation)
            {
                Play();
            }
        }

        private void CheckExit(Location exitLoc)
        {
            if (exitLoc.ItemRequired == null)
            {
                currentLocation = exitLoc;
            }
            else
            {
                if (exitLoc.ItemRequired == Player.ItemInHand)
                {
                    currentLocation = exitLoc;
                }
                else
                {
                    DisplayStory($"\nYou need the {exitLoc.ItemRequired.Name} in your hand to enter {exitLoc.DisplayName}");
                }
            }
        }

        private void ExamineItem(ListBox lb)
        {
            if (lb.SelectedItems.Count > 0)
            {
                Item item = dictItems[lb.SelectedItem.ToString()];
                DisplayStory($"\nYou look at the {item.Name} ");
                DisplayStory(item.Description);
            }
        }

        private void TakeItem()
        {
            if (lstLocation.SelectedItems.Count > 0)
            {
                Player.AddToInventory(dictItems[lstLocation.SelectedItem.ToString()]);
                DisplayStory($"\nYou take the {lstLocation.SelectedItem}");
                currentLocation.RemoveItem(lstLocation.SelectedItem.ToString());
                DisplayItemList();
                DisplayInventory();
            }
        }

        private void HoldItem()
        {
            if (lstInventory.SelectedItems.Count > 0)
            {
                Player.GetItemFromInventory(lstInventory.SelectedItem.ToString());
                DisplayStory($"\nYou get the {Player.ItemInHand.Name} from your backpack");
                DisplayInventory();
                DisplayHand();
            }
        }

        private void DropItem()
        {
            DisplayStory($"\nYou drop the {Player.ItemInHand.Name}");
            currentLocation.AddItem(Player.ItemInHand);
            Player.ItemInHand = null;
            DisplayItemList();
            DisplayHand();
        }

        private void ReturnItem()
        {
            Player.ReturnItemToInventory();
            DisplayInventory();
            DisplayHand();
        }

        private void UseItem()
        {
            Item currentItem = Player.ItemInHand;
            if (currentItem == null)
            {
                DisplayStory("\nYou are not holding anything in your hand!", true);
            }
            else
            {
                if (currentItem is Weapon)
                {
                    Weapon weapon = (Weapon)currentItem;
                    DisplayStory($"\nYou use the {weapon.Name} to scratch the wall with {weapon.Damage} points of damage");
                }
                else if (currentItem is Potion)
                {
                    Potion potion = (Potion)currentItem;
                    DisplayStory($"\nYou use the {potion.Name} for a health boost of {potion.Healing} and feel so much better!");
                    Player.ItemInHand = null;
                    DisplayHand();
                }
                else if (currentItem is Note)
                {
                    Note note = (Note)currentItem;
                    DisplayStory($"\nThe {note.Name} in your hand is {note.Description} which reads:\n'{note.Message}'");
                }
            }
        }
    }
}
