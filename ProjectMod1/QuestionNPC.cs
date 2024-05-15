using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    internal class QuestionNPC : INonPlayerCharacter
    {
        private readonly string _name;
        private readonly string _description;
        private readonly Item[] _items;
        private int _countItems;

        public QuestionNPC(string name, string description)
        {
            _name = name;
            _description = description;
            _items = new Item[10];
            _countItems = 0;
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

        public void IntroduceNPC(int level)
        {
            AnsiConsole.MarkupLine("[yellow]If you want me help to guide your path...\n you will have to give me the correct answer...\n are you ready?\n here I go....[/]");            

        }

        public void AddItem(int level)
        {
            switch (level)
            {
                case 1:
                    string itemName = "Dagger";
                    string itemDescription = "Dagger created in the Hellrock volcano";
                    Types itemType = Types.Fire;

                    _items[_countItems] = new Item(itemName, itemDescription, itemType);
                    _countItems++;
                    break;
                case 4:
                    string itemName4 = "Fire Knife";
                    string itemDescription4 = "The knife most faster of the world, the enemies will don't know who cut them";
                    Types itemType4 = Types.Fire;

                    _items[_countItems] = new Item(itemName4, itemDescription4, itemType4);
                    _countItems++;
                    break;
                case 6:
                    string itemName6 = "Sacred Arrows";
                    string itemDescription6 = "These arrows always reach their target";
                    Types itemType6 = Types.Silver;

                    _items[_countItems] = new Item(itemName6, itemDescription6, itemType6);
                    _countItems++;
                    break;
                case 9:
                    string itemName9 = "Power Spear";
                    string itemDescription9 = "This spear was created by the grandmasters to defeat everyone";
                    Types itemType9 = Types.Gold;

                    _items[_countItems] = new Item(itemName9, itemDescription9, itemType9);
                    _countItems++;
                    break;
                default:
                    break;
            }
        }
    }
}
