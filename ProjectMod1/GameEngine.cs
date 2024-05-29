using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ProjectMod1.GameText;

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
            InfoGame locationInfo = GetLocationInformation(_countLocations);            
            INonPlayerCharacter characterLevel = CreateCharacter();

            Location locationLevel = new Location(locationInfo.Name, locationInfo.Description, characterLevel);
            _locations[_countLocations] = locationLevel;
            _countLocations++;         

        }

        public INonPlayerCharacter CreateCharacter()
        {
            INonPlayerCharacter? newCharacter = null;
            InfoGame characterInfo = GetCharacterInformation(_countLocations);            

            Dictionary<int, Action> characterByLevel = new Dictionary<int, Action>
            {
                {0,() => newCharacter = new YesNoNPC(characterInfo.Name, characterInfo.Description) },
                {1, () => newCharacter = new QuestionNPC(characterInfo.Name, characterInfo.Description) },
                {2,() => newCharacter = new YesNoNPC(characterInfo.Name, characterInfo.Description) },
                {3,() => {newCharacter = new Boss(characterInfo.Name, characterInfo.Description, Types.Fire); _countBoss++; }},
                {4, () => newCharacter = new QuestionNPC(characterInfo.Name, characterInfo.Description) },
                {5,() => newCharacter = new YesNoNPC(characterInfo.Name, characterInfo.Description) },
                {6, () => newCharacter = new QuestionNPC(characterInfo.Name, characterInfo.Description) },
                {7,() => {newCharacter = new Boss(characterInfo.Name, characterInfo.Description, Types.Gold);  _countBoss++; }},
                {8,() => newCharacter = new YesNoNPC(characterInfo.Name, characterInfo.Description) },
                {9, () => newCharacter = new QuestionNPC(characterInfo.Name, characterInfo.Description) },
                {10,() => newCharacter = new YesNoNPC(characterInfo.Name, characterInfo.Description) },
                {11,() => {newCharacter = new Boss(characterInfo.Name, characterInfo.Description, Types.BloodDragon);  _countBoss++; } },
            };

            characterByLevel[_countLocations]();            
            
            return newCharacter;
        }        

        public void InteraccionPlayerWithNPC(int position)
        {
            
            if (_locations[position].Character is QuestionNPC)
            {
                IteractionPlayerQuestionNPC(position);
            }

            if (_locations[position].Character is YesNoNPC)
            {
                IteractionPlayerYesNoNPC(position);
            }
            else if (_locations[position].Character is Boss)
            {                
                IteractionPlayerBoss(position);
            }
        }

        private void IteractionPlayerQuestionNPC(int position)
        {
            InteractionQuestionNPC(position);
            AddLocation();
            Player1.GetPlayerDecisions();
            AnsiConsole.Clear();
        }

        private void IteractionPlayerYesNoNPC(int position)
        {
            DecisionPlayerWithYesNoNPC(position);
            Player1.GetPlayerDecisions();
            AddLocation();
            AnsiConsole.Clear();
        }

        private void IteractionPlayerBoss(int position)
        {
            List<string> itemSelected = SelectItemsPlayer();
            List<Types> itemsTypesSelected = Player1.ChekingItemsType(itemSelected);
            FightingWithBoss(position, itemsTypesSelected, _countBoss);
            AddLocation();
            Player1.GetPlayerDecisions();
            AnsiConsole.Clear();
        }
        private void CheckAnswer(string question, string answer, int position, int indice)
        {
            Item itemLevel2 = Locations[position].Character.Items[indice];
            indice++;

            if (question.ToLower().Contains(answer.ToLower()))
            {
                GameAnsiConsole.AnswerQuestionNPC(itemLevel2);                
                Player1.AddItem(itemLevel2);
            }
        }

        private void InteractionQuestionNPC(int position)
        {
            int indice = 0;

            InfoGame question = GameText.GetQuestionsNPC(position);
            string ask1 = GameAnsiConsole.AskQuestionNPC(question.Name);
            CheckAnswer(ask1, question.Description, position, indice);            
        }

        public void SettingLocation(int position)
        {
            GetLocationInfo(position);
            GetCharacterIntroduction(position);
            Locations[position].Character.AddItem(position);
        }

        private void GetLocationInfo(int position)
        {
            GameAnsiConsole.GetLocationInformation(Locations[position]);
        }

        private void GetCharacterIntroduction(int position)
        {
            GameAnsiConsole.GetNPCIntroduction(Locations[position]);            
            Locations[position].Character.IntroduceNPC(position);
        }

        private void DecisionPlayerWithYesNoNPC(int position)
        {
            int indice = 0;
            string title = "What do you want to do?";

            string decisionNPC1 = GameAnsiConsole.CreateDecisionPlayer(title, "Yes, Help", "No, Continue with my trip");            

            Item itemLevel1 = Locations[position].Character.Items[indice];
            indice++;

            if (decisionNPC1 == "Yes, Help")
            {
                GameAnsiConsole.AnswerYesNoNPC(itemLevel1);                
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
                

        private void FightingWithBoss(int position, List<Types> itemsTypeSelected, int bossNumber)
        {
            Types bossWeakness = _bossWeakness[bossNumber];
            bool checkItem = false;
            foreach (var item in itemsTypeSelected)
            {
                if (bossWeakness == item)
                {
                    checkItem = true;
                    break;
                }
            }
            GameAnsiConsole.CheckVictory(checkItem);            
        }         
    }
}
