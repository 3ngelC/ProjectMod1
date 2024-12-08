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
                

        public void GetPlayerDecisions()
        {
            bool next = false;

            do
            {
                string decisionPlayer1 = PromptPlayerAction();

                Dictionary<string, Action> action = new Dictionary<string, Action>
                {
                    {"Display Name",() => DisplayName()},
                    {"Display Description", () => DisplayDescription()},
                    {"Display Items", () => DisplayItems()},
                    {"Continue", () => next = true}
                };

                action[decisionPlayer1]();               
                
            } while (!next);
        }

        public string PromptPlayerAction()
        {
            return GameAnsiConsole.CreateDecisionPlayer("Player information", "Display Name", "Display Description", "Display Items", "Continue");            
        }

        public void DisplayName()
        {
            AnsiConsole.WriteLine("\nName:" + Name);
        }

        public void DisplayDescription()
        {
            AnsiConsole.WriteLine("\nDescription:" + Description);
        }

        public void DisplayItems()
        {
            AnsiConsole.WriteLine("\nItems:");
            
            var table = GameAnsiConsole.CreateTable("Item", "Description", "Type");

            GameAnsiConsole.AddItemsTable(table, _items);            
            AnsiConsole.Write(table);
        }                

        public string[] GetItemNamePlayer()
        {                     
            return _items
                    .Where(item => item != null && item.ItemName != null)
                    .Select(item => item.ItemName)
                    .ToArray();
        }

        public List<Types> ChekingItemsType(List<string> itemsSelected)
        {         
            var itemTypesSelected = from item in _items
                                    where item != null && item.ItemName != null
                                    join itemNames in itemsSelected
                                    on item.ItemName equals itemNames                                    
                                    select item.ItemType;

            return itemTypesSelected.ToList();
        }

    }
    
}
