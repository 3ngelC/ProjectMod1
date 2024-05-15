using Spectre.Console;
using System.Reflection.Emit;

namespace ProjectMod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
            AnsiConsole.MarkupLine($"Hello [green]{name}[/]!");

            var description = AnsiConsole.Ask<string>("Please insert a description for your character:");

            GameEngine start = new GameEngine(name, description);

            start.GetGameTitle();
            start.GetStartDescription();            

            ///Level 0
            start.AddLocation();
            int position = 0;
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);;
            position++;
            //Level1
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //Level2
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;            
            //Level 3
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 4
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level5
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 6
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 7
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;;
            //level 8
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 9
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 10
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            position++;
            //level 11
            start.SettingLocation(position);
            start.InteraccionPlayerWithNPC(position);
            start.GetFinalDescription();          

        }
    }
}
