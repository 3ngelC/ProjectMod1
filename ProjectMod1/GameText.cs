using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public class GameText
    {
        public static string GetIntroduccionNPC(int position)
        {
            Dictionary<int, string> introduction = new Dictionary<int, string>
            {
                {0, "I'm and old man, that lives in this town please help me to find my cat"},
                {2, "I'm lost, please help me to find my parents!" },
                {5, "Help me set up a wonderful table to have an extraordinary coffee!\nyou will be rewarded...or maybe not" },
                {8, "]Please help me defeat the goblin that took over our warehouse." },
                {10, "Please help me save the princess" },
                {6, "If you want me help to guide your path...\n you will have to give me the correct answer...\n are you ready?\n here I go...." },
                {3, "I will crush everything in my path.\nPrepare yourself to loss..." },
                {7, "With my power I defeated entire legions.\n you will not be able to defeat me..." },
                {11, "I am the king, you have no authority over me\nI will destroy you!\nYou will regret coming here" }
            };

            return introduction[position];
        }

        public static string GetItemInformation(double position)
        {
            Dictionary<double, string> itemInfo = new Dictionary<double, string>
            {
                {0, "armor cloak" },
                {0.5, "A magic cloak gives you more resistance against physical damage" },
                {1,"Dagger" },
                {1.5, "Dagger created in the Hellrock volcano" },
                {2, "Gold Sword" },
                {2.5, "Sword that was created by King Midas" },
                {3, "Gold Armor" },
                {3.5,  "It gives you protection and regeneration of life"},
                {4, "Fire Knife" },
                {4.5, "The knife most faster of the world, the enemies will don't know who cut them" },
                {5, "Invisibility cloak" },
                {5.5, "Disappears from the sight of all mortals" },
                {6, "Sacred Arrows" },
                {6.5, "These arrows always reach their target" },
                {7, "Blood Crown" },
                {7.5, "Increases the damage of all your weapons" },
                {8, "Metal Gloves" },
                {8.5, "Increases the power of all your blows" },
                {9, "Power Spear" },
                {9.5, "This spear was created by the grandmasters to defeat everyone" },
                {10, "Dragon Blood Chains" },
                {10.5, "An ancient dragon gave its blood to create powerful weapons" },
                {11, "Medal of Honor" },
                {11.5, "Give you the most importan range in the kingdom" }                
            };

            return itemInfo[position];
        }

        public static string GetLocationInformation(double position)
        {
            Dictionary<double, string> LocationInfo = new Dictionary<double, string>
            {
                {0, "Village bakery" },
                {0.5, "This place used to be the most visited by the entire town, a place where everyone could spend a pleasant time" },
                {1,"Forest charming" },
                {1.5, "someone could be nearing you, watching you.....be careful" },
                {2, "Downtown area" },
                {2.5, "The downtown of the city could be crazy, in specific days it is crowded." },
                {3, "Enchanted Mountain" },
                {3.5, "Wonderful and mysterious creatures live in this mountain." },
                {4, "Forest" },
                {4.5, "Beautiful forest, with magical creatures" },
                {5, "Tea room" },
                {5.5, "A particular cafe in the town" },
                {6, "Downtown area" },
                {6.5, "The forest meadow, where the greenest grass grows." },
                {7, "Entrance to the Castle" },
                {7.5, "Anyone who wants to enter the castle must pass through this point." },
                {8, "Castle kitchen" },
                {8.5, "In this place the most delicious dishes are prepared." },
                {9, "Castle hall" },
                {9.5, "A very busy place in the castle." },
                {10, "Main room" },
                {10.5, "A place where they met to make the most important decisions of the kingdom." },
                {11, "King's Room" },
                {11.5, "Place where the king lives." }
            };

            return LocationInfo[position];
        }

        public static string GetCharacterInformation(double position)
        {
            Dictionary<double, string> CharacterInfo = new Dictionary<double, string>
            {
                {0,  "Renafh"},
                {0.5, "Baker of the village" },
                {1, "Wisel" },
                {1.5, "whisper of the forest" },
                {2, "Rick" },
                {2.5, "A little boy" },
                {3, "Destroyer"},
                {3.5, "The strongest giant of the montains, expert warrior, he has a great ax instead of his left arm, he lost his arm in a battle against a dragon." },
                {4, "Allaf" },
                {4.5, "Dwarf boss\r\nruler of the forest dwarves" },
                {5, "Happy" },
                {5.5, "happiest man, he loves coffee" },
                {6, "Hawk" },
                {6.5, "I'm the watch of the forest from the beginning" },
                {7, "Bruskar" },
                {7.5, "goblin warrior\r\nThe most powerful warrior of the tribe. He will do everything to defend the treasure he has accumulated." },
                {8, "Frango" },
                {8.5, "village cook" },
                {9, "James" },
                {9.5, "King's guardian" },
                {10, "Hugo" },
                {10.5, "king's butler" },
                {11, "Diabolic king" },
                {11.5, "The king possessed by darkness, A demon with the help of a dragon cast a great spell on the king, dragging him into the darkness..." }
            };

            return CharacterInfo[position];
        }
    }
}
