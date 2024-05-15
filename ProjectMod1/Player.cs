using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    internal class Player : ICharacter
    {
        private readonly string _name;
        private readonly string _description;
        private readonly Item[] _items;
        private int _countItemsPlayer;

        public Player(string name, string description)
        {
            _name = name;
            _description = description;
            _items = new Item[20];
            _countItemsPlayer = 0;
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

        public void AddItem(Item item) 
        {
            _items[_countItemsPlayer] = item;
            _countItemsPlayer++;
        }
                

        public void DecisionsPlayer()
        {
            bool next = false;
            do
            {
                var decisionPlayer1 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[green]\n\nPlayer information[/]")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Display Name", "Display Description", "Display Items", "Continue"
                    }));

                switch (decisionPlayer1)
                {
                    case "Display Name":
                        AnsiConsole.WriteLine("\nName:" + Name);                        
                        break;
                    case "Display Description":
                        AnsiConsole.WriteLine("\nDescription:" + Description);                        
                        break;
                    case "Display Items":
                        AnsiConsole.WriteLine("\nItems:");
                        var table = new Table();
                        table.AddColumn("Item");
                        table.AddColumn("Description");
                        table.AddColumn("Type");

                        foreach (var item in _items)
                        {                        
                            
                            if (item != null)
                            {
                                table.AddRow(item.ItemName, item.ItemDescription, item.ItemType.ToString());
                            }
                        }
                        AnsiConsole.Write(table);                        
                        break;
                    case "Continue":                        
                        next = true;
                        break;
                }
            } while (!next);
        }

        public string[] ConverStringItemNamePlayer()
        {
            
            string[] itemNames = new string[_countItemsPlayer];
            for (int i = 0; i < _countItemsPlayer; i++)
            {
                itemNames[i] = Items[i].ItemName;
            }
            return itemNames;
        }

        public List<Types> ChekingItemsType(List<string> itemsSelected)
        {
            List<Types> itemTypesSelected = new List<Types>();
            for(int i =0; i < _countItemsPlayer; i++)
            {
                string itemName = Items[i].ItemName;
                foreach(var item in itemsSelected)
                {
                    if (itemName == item)
                    {                        
                        itemTypesSelected.Add(Items[i].ItemType);
                    }
                }
            }
            return itemTypesSelected;
        }

    }
    
}
