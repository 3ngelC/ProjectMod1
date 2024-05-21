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
            string description = GameText.GetIntroduccionNPC(level);

            AnsiConsole.MarkupLine($"[yellow]{description}[/]");                        
        }

        public void AddItem(int level)
        {
            double name = Convert.ToDouble(level);
            double description = name + 0.5;

            _items[_countItems] = new Item(GameText.GetItemInformation(name), GameText.GetItemInformation(description), ItemType.GetItemType(level));
            _countItems++;            
        }
    }
}
