using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectMod1.GameText;

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

        public static InfoGame GetIntroduccionGame()
        {
            var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
            AnsiConsole.MarkupLine($"Hello [green]{name}[/]!");
            var description = AnsiConsole.Ask<string>("Please insert a description for your character:");

            return new InfoGame(name, description);
        }
        public static void AnswerQuestionNPC(Item itemLevel2)
        {
            AnsiConsole.MarkupLine("[yellow]\n\n\nI will leave my hopes on you...\nI know I can trust you...[/]");
            WaitingForPlayer();
            AnsiConsole.MarkupLine($"\n\n[magenta]You got the following item:[/][yellow] {itemLevel2.ItemName}[/]\n[magenta]Description:[/][yellow] {itemLevel2.ItemDescription}[/]\n[magenta]Item Type:[/][yellow] {itemLevel2.ItemType}[/]\n");
        }

        public static void AnswerYesNoNPC(Item itemLevel1)
        {
            AnsiConsole.MarkupLine("\n[yellow]Thanks for helping me, I wish you the best in your journey\n\n\n\n[/]");
            GameAnsiConsole.WaitingForPlayer();
            AnsiConsole.MarkupLine($"\n\n[magenta]You got the following item:[/] [yellow]{itemLevel1.ItemName}[/]\n[magenta]Description:[/] [yellow]{itemLevel1.ItemDescription}[/]\n[magenta]Item Type:[/][yellow] {itemLevel1.ItemType}[/]\n");
        }
        public static string AskQuestionNPC(string question)
        {
            var ask1 = AnsiConsole.Ask<string>($"[yellow]{question}[/]");

            return ask1;
        }

        public static void GetGameTitle()
        {
            AnsiConsole.Clear();
            AnsiConsole.WriteLine(Constants.gameTitle);
        }

        public static void GetStartDescription()
        {
            AnsiConsole.MarkupLine($"[yellow]{Constants.descriptionGame}[/]");
            WaitingForPlayer();
        }

        public static void GetFinalDescription()
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine($"[green]{Constants.finalDescription}[/]");
            WaitingForPlayer();
            AnsiConsole.WriteLine(Constants.finalMessage);                                          
        }

        public static void WaitingForPlayer()
        {
            AnsiConsole.MarkupLine("[blue]Press any button to continue...[/]");
            System.Console.CursorVisible = false;
            System.Console.ReadKey(true);
            System.Console.CursorVisible = true;
            AnsiConsole.Clear();
        }

        private static void FightingAnimation()
        {
            AnsiConsole.Status()
                .Start("Fighting...", ctx =>
                {
                    ctx.Spinner(Spinner.Known.Star);
                    Thread.Sleep(2000);
                });
        }

        public static void CheckVictory(bool checkItem)
        {
            AnsiConsole.Clear();
            FightingAnimation();

            if (checkItem)
            {                
                AnsiConsole.MarkupLine("[yellow] You defeated the boss[/]");
            }
            else
            {                
                AnsiConsole.MarkupLine("[red]You don't have enough power.....\nYOU LOSE\nGAME OVER[/]");
                Environment.Exit(0);
            }
        }

        public static void GetLocationInformation(Location locationInfo)
        {
            AnsiConsole.MarkupLine($"\n[green]-------------Location: {locationInfo.NameLocation}--------------------[/]\n");
            AnsiConsole.MarkupLine($"[cyan]{locationInfo.DescriptionLocation}[/]\n\n\n\n");
            AnsiConsole.MarkupLine("[yellow]Someone is in front of you...[/]\n\n\n\n ");
            WaitingForPlayer();
        }

        public static void GetNPCIntroduction(Location locationInfo)
        {
            AnsiConsole.MarkupLine($"\n[green]-------------Location: {locationInfo.NameLocation}--------------------[/]\n");
            AnsiConsole.MarkupLine($"Hello my name is:[blue] {locationInfo.Character.Name}[/]\n");
            AnsiConsole.MarkupLine($"[cyan]Description: {locationInfo.Character.Description}[/]\n\n\n");            
        }
    }
}
