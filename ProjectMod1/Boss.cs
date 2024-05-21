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
