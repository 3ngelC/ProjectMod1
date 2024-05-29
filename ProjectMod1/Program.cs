using Spectre.Console;
using System.Reflection.Emit;
using static ProjectMod1.GameText;

namespace ProjectMod1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            InfoGame player = GameAnsiConsole.GetIntroduccionGame();
            GameEngine start = new GameEngine(player.Name, player.Description);

            GameAnsiConsole.GetGameTitle();
            GameAnsiConsole.GetStartDescription();            
            int position = 0;
            start.AddLocation();
            while (position <= 11)
            {
                start.SettingLocation(position);
                start.InteraccionPlayerWithNPC(position);
                position++;

                if (position == 11)
                {
                    GameAnsiConsole.GetFinalDescription();
                }
            }        
        }
    }
}
