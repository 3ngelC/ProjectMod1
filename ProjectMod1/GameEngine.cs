using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Location? locationLevel = null;
            switch (_countLocations)
            {
                case 0:
                    INonPlayerCharacter characterLevel = CreateCharacter();
                    string name = "Village bakery";
                    string description = "This place used to be the most visited by the entire town, a place where everyone could spend a pleasant time";
                    locationLevel = new Location(name, description, characterLevel);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;                    
                    break;
                case 1:
                    INonPlayerCharacter characterLevel1 = CreateCharacter();
                    string name1 = "Forest charming";
                    string description1 = "someone could be nearing you, watching you.....be careful";
                    locationLevel = new Location(name1, description1, characterLevel1);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;                    
                    break;
                case 2:
                    INonPlayerCharacter characterLevel2 = CreateCharacter();
                    string name2 = "Downtown area";
                    string description2 = "The downtown of the city could be crazy, in specific days it is crowded.";
                    locationLevel = new Location(name2, description2, characterLevel2);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;                    
                    break;
                case 3:
                    INonPlayerCharacter characterLevel3 = CreateCharacter();
                    string name3 = "Enchanted Mountain";
                    string description3 = "Wonderful and mysterious creatures live in this mountain.";
                    locationLevel = new Location(name3, description3, characterLevel3);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 4:
                    INonPlayerCharacter characterLevel4 = CreateCharacter();
                    string name4 = "Forest";
                    string description4 = "Beautiful forest, with magical creatures";
                    locationLevel = new Location(name4, description4, characterLevel4);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 5:
                    INonPlayerCharacter characterLevel5 = CreateCharacter();
                    string name5 = "Tea room";
                    string description5 = "A particular cafe in the town";
                    locationLevel = new Location(name5, description5, characterLevel5);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 6:
                    INonPlayerCharacter characterLevel6 = CreateCharacter();
                    string name6 = "Downtown area";
                    string description6 = "The forest meadow, where the greenest grass grows.";
                    locationLevel = new Location(name6, description6, characterLevel6);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 7:
                    INonPlayerCharacter characterLevel7 = CreateCharacter();
                    string name7 = "Entrance to the Castle";
                    string description7 = "Anyone who wants to enter the castle must pass through this point.";
                    locationLevel = new Location(name7, description7, characterLevel7);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 8:
                    INonPlayerCharacter characterLevel8 = CreateCharacter();
                    string name8 = "Castle kitchen";
                    string description8 = "In this place the most delicious dishes are prepared.";
                    locationLevel = new Location(name8, description8, characterLevel8);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 9:
                    INonPlayerCharacter characterLevel9 = CreateCharacter();
                    string name9 = "Castle hall";
                    string description9 = "A very busy place in the castle.";
                    locationLevel = new Location(name9, description9, characterLevel9);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 10:
                    INonPlayerCharacter characterLevel10 = CreateCharacter();
                    string name10 = "Main room";
                    string description10 = "A place where they met to make the most important decisions of the kingdom.";
                    locationLevel = new Location(name10, description10, characterLevel10);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                case 11:
                    INonPlayerCharacter characterLevel11 = CreateCharacter();
                    string name11 = "King's Room";
                    string description11 = "Place where the king lives.";
                    locationLevel = new Location(name11, description11, characterLevel11);
                    _locations[_countLocations] = locationLevel;
                    _countLocations++;
                    break;
                
            }

        }

        public INonPlayerCharacter CreateCharacter()
        {
            INonPlayerCharacter? newCharacter = null;
            switch (_countLocations) 
            {
                case 0:
                    string name = "Renafh";
                    string description = "Baker of the village";
                    newCharacter = new YesNoNPC(name, description);
                    break;
                case 1:
                    string name1 = "Wisel";
                    string description1 = "whisper of the forest";
                    newCharacter = new QuestionNPC(name1, description1);
                    break;
                case 2:
                    string name2 = "Rick";
                    string description2 = "A little boy";
                    newCharacter = new YesNoNPC(name2, description2);
                    break;
                case 3:
                    string name3 = "Destroyer";
                    string description3 = "The strongest giant of the montains, expert warrior, he has a great ax instead of his left arm, he lost his arm in a battle against a dragon.";
                    newCharacter = new Boss(name3, description3, Types.Fire);
                    _bossWeakness[_countBoss] = Types.Fire;
                    _countBoss++;
                    break;
                case 4:
                    string name4 = "Allaf";
                    string description4 = "Dwarf boss\r\nruler of the forest dwarves";
                    newCharacter = new QuestionNPC(name4, description4);
                    break;
                case 5:
                    string name5 = "Happy";
                    string description5 = "happiest man, he loves coffee";
                    newCharacter = new YesNoNPC(name5, description5);
                    break;
                case 6:
                    string name6 = "Hawk";
                    string description6 = "I'm the watch of the forest from the beginning";
                    newCharacter = new QuestionNPC(name6, description6);
                    break;
                case 7:
                    string name7 = "Bruskar";
                    string description7 = "goblin warrior\r\nThe most powerful warrior of the tribe. He will do everything to defend the treasure he has accumulated.";
                    newCharacter = new Boss(name7, description7, Types.Gold);
                    _bossWeakness[_countBoss] = Types.Gold;
                    _countBoss++;
                    break;
                case 8:
                    string name8 = "Frango";
                    string description8 = "village cook";
                    newCharacter = new YesNoNPC(name8, description8);
                    break;
                case 9:
                    string name9 = "James";
                    string description9 = "King's guardian";
                    newCharacter = new QuestionNPC(name9, description9);
                    break;
                case 10:
                    string name10 = "Hugo";
                    string description10 = "king's butler";
                    newCharacter = new YesNoNPC(name10, description10);
                    break;
                case 11:
                    string name11 = "Diabolic king";
                    string description11 = "The king possessed by darkness, A demon with the help of a dragon cast a great spell on the king, dragging him into the darkness...";
                    newCharacter = new Boss(name11, description11, Types.BloodDragon);
                    _bossWeakness[_countBoss] = Types.BloodDragon;
                    _countBoss++;
                    break;
                
            }
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
                Player1.DecisionsPlayer();
                AnsiConsole.Clear();
            }

            if (_locations[position].Character is YesNoNPC)
            {
                DecisionPlayerWithYesNoNPC(position);
                Player1.DecisionsPlayer();
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
                Player1.DecisionsPlayer();
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
            string[] itemOptions = Player1.ConverStringItemNamePlayer();

            Player1.DecisionsPlayer();
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
