using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMod1.GameText;

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
            int positionDescription = 6;
            string description = GameText.GetIntroduccionNPC(positionDescription);

            AnsiConsole.MarkupLine($"[yellow]{description}[/]");            

        }

        public void AddItem(int level)
        {
            InfoGame itemInfo = GetItemInformation(level);

            _items[_countItems] = new Item(itemInfo.Name, itemInfo.Description, ItemType.GetItemType(level));
            _countItems++;
        }


    }
}
