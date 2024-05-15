using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    internal class YesNoNPC : INonPlayerCharacter
    {
        private readonly string _name;
        private readonly string _descriptionNPC;
        private readonly Item[] _items;
        private int _countItems;
        
        public YesNoNPC (string name, string description)
        {
            _name = name;
            _descriptionNPC = description;
            _items = new Item[10];
            _countItems = 0;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _descriptionNPC; }
        }

        public Item[] Items
        {
            get { return _items; }
        }

        public void IntroduceNPC(int level)
        {
            switch (level)
            {
                case 0:
                    AnsiConsole.MarkupLine("[yellow]I'm and old man, that lives in this town please help me to find my cat[/]");
                    break;
                case 2:
                    AnsiConsole.MarkupLine("[yellow]I'm lost, please help me to find my parents![/]");
                    break;
                case 5:
                    AnsiConsole.MarkupLine("[yellow]Help me set up a wonderful table to have an extraordinary coffee!\nyou will be rewarded...or maybe not[/]");
                    break;
                case 8:
                    AnsiConsole.MarkupLine("[yellow]Please help me defeat the goblin that took over our warehouse.[/]");
                    break;
                case 10:
                    AnsiConsole.MarkupLine("[yellow]Please help me save the princess[/]");
                    break;
                default:
                    break;
            }             
        }

        public void AddItem(int level)
        {
            switch (level)
            {
                case 0:
                    string itemName = "armor cloak";
                    string itemDescription = "A magic cloak gives you more resistance against physical damage";
                    Types itemType = Types.Silver;

                    _items[_countItems] = new Item(itemName, itemDescription, itemType);
                    _countItems++;
                    break;
                case 2:
                    string itemName2 = "Gold Sword";
                    string itemDescription2 = "Sword that was created by King Midas";
                    Types itemType2 = Types.Gold;

                    _items[_countItems] = new Item(itemName2, itemDescription2, itemType2);
                    _countItems++;
                    break;
                case 5:
                    string itemName5 = "Invisibility cloak";
                    string itemDescription5 = "Disappears from the sight of all mortals";
                    Types itemType5 = Types.Silver;

                    _items[_countItems] = new Item(itemName5, itemDescription5, itemType5);
                    _countItems++;
                    break;
                case 8:
                    string itemName8 = "Metal Gloves";
                    string itemDescription8 = "Increases the power of all your blows";
                    Types itemType8 = Types.Gold;

                    _items[_countItems] = new Item(itemName8, itemDescription8, itemType8);
                    _countItems++;
                    break;
                case 10:
                    string itemName10 = "Dragon Blood Chains";
                    string itemDescription10 = "An ancient dragon gave its blood to create powerful weapons";
                    Types itemType10 = Types.BloodDragon;

                    _items[_countItems] = new Item(itemName10, itemDescription10, itemType10);
                    _countItems++;
                    break;
                default:
                    break;
            }
        }
    }
}
