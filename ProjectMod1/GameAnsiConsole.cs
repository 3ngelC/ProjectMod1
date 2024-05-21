using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public class GameAnsiConsole
    {
        public static Table CreateTable(params string[] columns)
        {
            var table = new Table();
            table.AddColumns(columns);

            return table;
        }

        public static void AddItemsTable(Table table, Item[] itemsAdd)
        {
            foreach (var item in itemsAdd)
            {
                if (item != null)
                {
                    table.AddRow(item.ItemName, item.ItemDescription, item.ItemType.ToString());
                }
            }
        }

        public static string CreateDecisionPlayer(string title, params string[] options)
        {
            var decisionPlayer1 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title($"[green]\n\n{title}[/]")
                    .PageSize(10)
                    .AddChoices(options));

            return decisionPlayer1.ToString();
        }
    }
}
