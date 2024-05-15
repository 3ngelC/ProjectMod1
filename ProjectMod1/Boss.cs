using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    internal class Boss : INonPlayerCharacter
    {
        private readonly string _name;
        private readonly string _description;
        private readonly Item[] _items;
        private int _countItems;
        private readonly Types _weakness;

        public Boss(string name, string description, Types weakness) 
        {
            _name = name;
            _description = description;
            _items = new Item[10];
            _countItems = 0;
            _weakness = weakness;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public Item[] Items
        {
            get { return _items; }
        }

        public Types Weakness
        {
            get { return _weakness; }
        }
        public void IntroduceNPC(int level)
        {
            switch (level)
            {
                case 3:
                    AnsiConsole.MarkupLine("[yellow]I will crush everything in my path.\nPrepare yourself to loss...[/]");
                    break;
                case 7:
                    AnsiConsole.MarkupLine("[yellow]With my power I defeated entire legions.\n you will not be able to defeat me...[/]");
                    break;
                case 11:
                    AnsiConsole.MarkupLine("[yellow]I am the king, you have no authority over me\nI will destroy you!\nYou will regret coming here[/]");
                    break;
                default:
                    break;
            }

        }

        public void AddItem(int level)
        {
            switch (level)
            {
                case 3:
                    string itemName = "Gold Armor";
                    string itemDescription = "It gives you protection and regeneration of life";
                    Types itemType = Types.Gold;

                    _items[_countItems] = new Item(itemName, itemDescription, itemType);
                    _countItems++;
                    break;
                case 7:
                    string itemName4 = "Blood Crown";
                    string itemDescription4 = "Increases the damage of all your weapons";
                    Types itemType4 = Types.BloodDragon;

                    _items[_countItems] = new Item(itemName4, itemDescription4, itemType4);
                    _countItems++;
                    break;
                case 11:
                    string itemName6 = "Medal of Honor";
                    string itemDescription6 = "Give you the most importan range in the kingdom";
                    Types itemType6 = Types.Gold;

                    _items[_countItems] = new Item(itemName6, itemDescription6, itemType6);
                    _countItems++;
                    break;                
                default:
                    break;
            }
        }
    }
}
