using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public class GameText
    {
        public struct InfoGame
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public InfoGame(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }
        

       
        public static string GetIntroduccionNPC(int position)
        {
            Dictionary<int, string> introduction = new Dictionary<int, string>
            {
                {0, Constants.introduccionNPC0},
                {2, Constants.introduccionNPC2},
                {5, Constants.introduccionNPC5 },
                {8, Constants.introduccionNPC8},
                {10, Constants.introduccionNPC10},
                {6, Constants.introduccionNPC6},
                {3, Constants.introduccionNPC3},
                {7, Constants.introduccionNPC7},
                {11, Constants.introduccionNPC11}
            };

            return introduction[position];
        }

        public static InfoGame GetItemInformation(int position)
        {
            Dictionary<int, InfoGame> itemInfo = new Dictionary<int, InfoGame>
            {
                {0, new InfoGame(Constants.itemName0, Constants.itemDescription0)},                
                {1, new InfoGame(Constants.itemName1, Constants.itemDescription1)},                
                {2, new InfoGame(Constants.itemName2, Constants.itemDescription2)},                
                {3, new InfoGame(Constants.itemName3, Constants.itemDescription3)},                
                {4, new InfoGame(Constants.itemName4, Constants.itemDescription4)},                
                {5, new InfoGame(Constants.itemName5, Constants.itemDescription5)},                
                {6, new InfoGame(Constants.itemName6, Constants.itemDescription6)},                
                {7, new InfoGame(Constants.itemName7, Constants.itemDescription7)},                
                {8, new InfoGame(Constants.itemName8, Constants.itemDescription8)},                
                {9, new InfoGame(Constants.itemName9, Constants.itemDescription9)},                
                {10, new InfoGame(Constants.itemName10, Constants.itemDescription10)},                
                {11, new InfoGame(Constants.itemName11, Constants.itemDescription11)},                                
            };

            return itemInfo[position];
        }

        public static InfoGame GetLocationInformation(int position)
        {
            Dictionary<int, InfoGame> LocationInfo = new Dictionary<int, InfoGame>
            {
                {0, new InfoGame(Constants.locationName0, Constants.locationDescription0)},                
                {1, new InfoGame(Constants.locationName1, Constants.locationDescription1)},                
                {2, new InfoGame(Constants.locationName2, Constants.locationDescription2)},                
                {3, new InfoGame(Constants.locationName3, Constants.locationDescription3)},                
                {4, new InfoGame(Constants.locationName4, Constants.locationDescription4)},                
                {5, new InfoGame(Constants.locationName5, Constants.locationDescription5)},                
                {6, new InfoGame(Constants.locationName6, Constants.locationDescription6)},                
                {7, new InfoGame(Constants.locationName7, Constants.locationDescription7)},                
                {8, new InfoGame(Constants.locationName8, Constants.locationDescription8)},                
                {9, new InfoGame(Constants.locationName9, Constants.locationDescription9)},                
                {10, new InfoGame(Constants.locationName10, Constants.locationDescription10)},                
                {11, new InfoGame(Constants.locationName11, Constants.locationDescription11)},                
            };

            return LocationInfo[position];
        }

        public static InfoGame GetCharacterInformation(int position)
        {
            Dictionary<int, InfoGame> CharacterInfo = new Dictionary<int, InfoGame>
            {
                {0, new InfoGame(Constants.characterName0, Constants.characterDescription0)},                
                {1, new InfoGame(Constants.characterName1, Constants.characterDescription1)},                
                {2, new InfoGame(Constants.characterName2, Constants.characterDescription2)},               
                {3, new InfoGame(Constants.characterName3, Constants.characterDescription3)},                
                {4, new InfoGame(Constants.characterName4, Constants.characterDescription4)},                
                {5, new InfoGame(Constants.characterName5, Constants.characterDescription5)},                
                {6, new InfoGame(Constants.characterName6, Constants.characterDescription6)},                
                {7, new InfoGame(Constants.characterName7, Constants.characterDescription7)},                
                {8, new InfoGame(Constants.characterName8, Constants.characterDescription8)},               
                {9, new InfoGame(Constants.characterName9, Constants.characterDescription9)},                
                {10, new InfoGame(Constants.characterName10, Constants.characterDescription10)},                
                {11, new InfoGame(Constants.characterName11, Constants.characterDescription11)},                
            };

            return CharacterInfo[position];
        }

        public static InfoGame GetQuestionsNPC(int position)
        {
            Dictionary<int, InfoGame> Questions = new Dictionary<int, InfoGame>
            {
                {1, new InfoGame(Constants.question1, Constants.answer1)},
                {4, new InfoGame(Constants.question2, Constants.answer2)},
                {6, new InfoGame(Constants.question3, Constants.answer3)},
                {9, new InfoGame(Constants.question4, Constants.answer4)},
            };

            return Questions[position];
        }

        
    }
}
