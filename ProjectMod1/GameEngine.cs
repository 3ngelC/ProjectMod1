using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectMod1
{
    internal class GameEngine
    {
        private readonly Location[] _locations;
        private readonly Types[] _bossWeakness;
        private readonly Player _player1;
        private int _countLocations;
        private int _countBoss;

        public GameEngine(string name, string description) 
        { 
            _locations = new Location[12];
            _bossWeakness = new Types[3];
            _player1 = new Player(name, description);
            _countLocations = 0;
            _countBoss = 0;
        }

        public Location[] Locations 
        { 
            get { return _locations; }
        }
                
        public Player Player1 
        { 
            get { return _player1; } 
        }

        public int CountLocations
        {
            get { return _countLocations; }
        }

        public void AddLocation()
        {
            double namePosition = Convert.ToDouble(_countLocations);
            double descriptionPosition = Convert.ToDouble(_countLocations) + 0.5;

            string nameLocation = GameText.GetLocationInformation(namePosition);
            string descriptionLocation = GameText.GetLocationInformation(descriptionPosition);
            INonPlayerCharacter characterLevel = CreateCharacter();

            Location locationLevel = new Location(nameLocation, descriptionLocation, characterLevel);
            _locations[_countLocations] = locationLevel;
            _countLocations++;         

        }

        public INonPlayerCharacter CreateCharacter()
        {
            INonPlayerCharacter? newCharacter = null;
            string name = GameText.GetCharacterInformation(Convert.ToDouble(_countLocations));
            string description = GameText.GetLocationInformation(Convert.ToDouble(_countLocations)+0.5);

            Dictionary<int, Action> characterByLevel = new Dictionary<int, Action>
            {
                {0,() => newCharacter = new YesNoNPC(name, description) },
                {1, () => newCharacter = new QuestionNPC(name, description) },
                {2,() => newCharacter = new YesNoNPC(name, description) },
                {3,() => newCharacter = new Boss(name, description, Types.Fire) },
                {4, () => newCharacter = new QuestionNPC(name, description) },
                {5,() => newCharacter = new YesNoNPC(name, description) },
                {6, () => newCharacter = new QuestionNPC(name, description) },
                {7,() => newCharacter = new Boss(name, description, Types.Gold) },
                {8,() => newCharacter = new YesNoNPC(name, description) },
                {9, () => newCharacter = new QuestionNPC(name, description) },
                {10,() => newCharacter = new YesNoNPC(name, description) },
                {11,() => newCharacter = new Boss(name, description, Types.BloodDragon) },
            };

            characterByLevel[_countLocations]();            
            
            return newCharacter;
        }

        private int GetBossNumber(int position)
        {
            int bossNumber = 0;
            if (position < 4)
            {
                bossNumber = 1;
            }
            if (position > 4 && position < 8)
            {
                bossNumber = 2;
            }
            else if (position > 8)
            {
                bossNumber = 3;
            }
            return bossNumber;
        }

        public void InteraccionPlayerWithNPC(int position)
        {
            
            if (_locations[position].Character is QuestionNPC)
            {
                InteractionQuestionNPC(position);
                AddLocation();                
                Player1.GetPlayerDecisions();
                AnsiConsole.Clear();
            }

            if (_locations[position].Character is YesNoNPC)
            {
                DecisionPlayerWithYesNoNPC(position);
                Player1.GetPlayerDecisions();
                AddLocation();
                AnsiConsole.Clear();
            }
            else if (_locations[position].Character is Boss)
            {                
                List<string> itemSelected = SelectItemsPlayer();
                List<Types> itemsTypesSelected = Player1.ChekingItemsType(itemSelected);
                int bossNumber = GetBossNumber(position);
                FightingWithBoss(position, itemsTypesSelected, bossNumber);
                AddLocation();                
                Player1.GetPlayerDecisions();
                AnsiConsole.Clear();
            }
        }

        private void CheckAnswer(string question, string answer, int position, int indice)
        {
            Item itemLevel2 = Locations[position].Character.Items[indice];
            indice++;

            if (question.ToLower().Contains(answer.ToLower()))
            {
                AnsiConsole.MarkupLine("[yellow]\n\n\nI will leave my hopes on you...\nI know I can trust you...[/]");
                WaitingForPlayer();
                AnsiConsole.MarkupLine($"\n\n[magenta]You got the following item:[/][yellow] {itemLevel2.ItemName}[/]\n[magenta]Description:[/][yellow] {itemLevel2.ItemDescription}[/]\n[magenta]Item Type:[/][yellow] {itemLevel2.ItemType}[/]\n");
                Player1.AddItem(itemLevel2);
            }
        }

        private void InteractionQuestionNPC(int position)
        {
            int indice = 0;

            switch(position)
            {
                case 1:
                    var ask1 = AnsiConsole.Ask<string>("[yellow]What has a face and two hands but no arms or legs[/]?");
                    string answer = "clock";
                    CheckAnswer(ask1, answer, position, indice);                    
                    break;
                case 4:
                    var ask2 = AnsiConsole.Ask<string>("[yellow]What has a thumb and four fingers but is not alive?[/]?");
                    string answer2 = "glove";
                    CheckAnswer(ask2, answer2, position, indice);                    
                    break;
                case 6:
                    var ask6 = AnsiConsole.Ask<string>("[yellow]What must be broken before you can use it?[/]?");
                    string answer6 = "egg";
                    CheckAnswer(ask6, answer6, position, indice);                    
                    break;
                case 9:
                    var ask9 = AnsiConsole.Ask<string>("[yellow]What goes up and doesn't come back down?[/]?");
                    string answer9 = "age";
                    CheckAnswer(ask9, answer9, position, indice);                    
                    break;
            }
        }

        public void SettingLocation(int position)
        {
            GetLocationInfo(position);
            GetCharacterIntroduction(position);
            Locations[position].Character.AddItem(position);
        }

        private void GetLocationInfo(int position)
        {            
            AnsiConsole.MarkupLine($"\n[green]-------------Location: {Locations[position].NameLocation}--------------------[/]\n");
            AnsiConsole.MarkupLine($"[cyan]{Locations[position].DescriptionLocation}[/]\n\n\n\n");
            AnsiConsole.MarkupLine("[yellow]Someone is in front of you...[/]\n\n\n\n ");
            WaitingForPlayer();
        }

        private void GetCharacterIntroduction(int position)
        {
            AnsiConsole.MarkupLine($"\n[green]-------------Location: {Locations[position].NameLocation}--------------------[/]\n");
            AnsiConsole.MarkupLine($"Hello my name is:[blue] {Locations[position].Character.Name}[/]\n");
            AnsiConsole.MarkupLine($"[cyan]Description: {Locations[position].Character.Description}[/]\n\n\n");
            Locations[position].Character.IntroduceNPC(position);
        }

        private void DecisionPlayerWithYesNoNPC(int position)
        {
            int indice = 0;

            var decisionNPC1 = AnsiConsole.Prompt(
               new SelectionPrompt<string>()
               .Title("[green]What do you want to do?[/]")
               .PageSize(10)
               .AddChoices(new[]
               {
                    "Yes, Help", "No, Continue with my trip"
               }));

            Item itemLevel1 = Locations[position].Character.Items[indice];
            indice++;

            if (decisionNPC1 == "Yes, Help")
            {
                AnsiConsole.MarkupLine("\n[yellow]Thanks for helping me, I wish you the best in your journey\n\n\n\n[/]");
                WaitingForPlayer();
                AnsiConsole.MarkupLine($"\n\n[magenta]You got the following item:[/] [yellow]{itemLevel1.ItemName}[/]\n[magenta]Description:[/] [yellow]{itemLevel1.ItemDescription}[/]\n[magenta]Item Type:[/][yellow] {itemLevel1.ItemType}[/]\n");
                Player1.AddItem(itemLevel1);
            }
        }
      
        public List<string> SelectItemsPlayer()
        {
            string[] itemOptions = Player1.GetItemNamePlayer();

            Player1.GetPlayerDecisions();
            var seleccion = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                 .Title("\n\nSelect items to fight:")
                    .PageSize(10)
                    .AddChoices(itemOptions));

            AnsiConsole.WriteLine("\nYou selected the following items");
            foreach (var item in seleccion)
            {
                AnsiConsole.WriteLine(item);
            }
            return seleccion;
        }

        private void CheckVictory(bool checkItem)
        {
            if (checkItem)
            {
                AnsiConsole.Clear();
                FightingAnimation();
                AnsiConsole.MarkupLine("[yellow] You defeated the boss[/]");
            }
            else
            {
                AnsiConsole.Clear();
                FightingAnimation();
                AnsiConsole.MarkupLine("[red]You don't have enough power.....\nYOU LOSE\nGAME OVER[/]");                
                Environment.Exit(0);
            }
        }

        private void FightingWithBoss(int position, List<Types> itemsTypeSelected, int bossNumber)
        {
            Types bossWeakness = _bossWeakness[bossNumber - 1];
            bool checkItem = false;
            foreach (var item in itemsTypeSelected)
            {
                if (bossWeakness == item)
                {
                    checkItem = true;
                    break;
                }
            }
            CheckVictory(checkItem);            
        }

        public void GetGameTitle()
        {
            AnsiConsole.Clear();
            AnsiConsole.WriteLine(@"
             █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████    ▄▄▄█████▓ ▒█████  
            ▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀    ▓  ██▒ ▓▒▒██▒  ██▒
            ▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███      ▒ ▓██░ ▒░▒██░  ██▒
            ░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄    ░ ▓██▓ ░ ▒██   ██░
            ░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒     ▒██▒ ░ ░ ████▓▒░
            ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░     ▒ ░░   ░ ▒░▒░▒░ 
              ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░       ░      ░ ▒ ▒░ 
              ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░        ░      ░ ░ ░ ▒  
                ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                ░ ░                                                                                             

                 ██ ▄█▀ ██▓ ███▄    █   ▄████     ██▓    ▄▄▄       ███▄    █ ▓█████▄ 
                 ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▓██▒   ▒████▄     ██ ▀█   █ ▒██▀ ██▌
                ▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██░   ▒██  ▀█▄  ▓██  ▀█ ██▒░██   █▌
                ▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓   ▒██░   ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█▄   ▌
                ▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒   ░██████▒▓█   ▓██▒▒██░   ▓██░░▒████▓ 
                ▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ░ ▒░▓  ░▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▒▓  ▒ 
                ░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░    ░ ░ ▒  ░ ▒   ▒▒ ░░ ░░   ░ ▒░ ░ ▒  ▒ 
                ░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░      ░ ░    ░   ▒      ░   ░ ░  ░ ░  ░ 
                ░  ░    ░           ░       ░        ░  ░     ░  ░         ░    ░  ░                   
            ");
        }

        public void GetStartDescription()
        {
            AnsiConsole.MarkupLine("[yellow]Some years ago Restland was a wonderful place to live, the king was fair, kindest, and he live for the kingdom.\n.........\n" +
                "but one day, the kingdom was invaded by the dark, and after months of fighting it, the king was taken into the darkness. from that day No one could see the king, no one could enter the castle again....and now the kingdom is dangerous there is a few places to feel safe, and few people to trust.\n" +
                "may the force be with you =)[/] ");
            WaitingForPlayer();
            
        }

        public void GetFinalDescription()
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("[green]Thanks to you, peace returned to the kingdom, and we are very grateful... \nYour name will be always remembered...\nWe will never forget it.[/]");
            WaitingForPlayer();            
            AnsiConsole.WriteLine(@"
             __     ______  _    _  __          _______ _   _ 
             \ \   / / __ \| |  | | \ \        / /_   _| \ | |
              \ \_/ / |  | | |  | |  \ \  /\  / /  | | |  \| |
               \   /| |  | | |  | |   \ \/  \/ /   | | | . ` |
                | | | |__| | |__| |    \  /\  /   _| |_| |\  |
                |_|  \____/ \____/      \/  \/   |_____|_| \_|                                             
               _____          __  __ ______    ______      ________ _____  
              / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
             | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
             | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
             | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
              \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                                  
            ");
        }

        private void WaitingForPlayer()
        {
            AnsiConsole.MarkupLine("[blue]Press any button to continue...[/]");
            System.Console.CursorVisible = false;
            System.Console.ReadKey(true);
            System.Console.CursorVisible = true;
            AnsiConsole.Clear();
        }

        private void FightingAnimation()
        {
            AnsiConsole.Status()
                .Start("Fighting...", ctx =>
                {                    
                    ctx.Spinner(Spinner.Known.Star);                    
                    Thread.Sleep(2000);                    
                });
        }
    }
}
