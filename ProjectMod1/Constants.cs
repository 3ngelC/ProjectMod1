using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public static class Constants
    {
        //Constants of the introduccion for each NPC
        public const string introduccionNPC0 = "I'm and old man, that lives in this town please help me to find my cat";
        public const string introduccionNPC2 = "I'm lost, please help me to find my parents!";
        public const string introduccionNPC5 = "Help me set up a wonderful table to have an extraordinary coffee!\nyou will be rewarded...or maybe not";
        public const string introduccionNPC8 = "Please help me defeat the goblin that took over our warehouse.";
        public const string introduccionNPC10 = "Please help me save the princess";
        public const string introduccionNPC6 = "If you want me help to guide your path...\n you will have to give me the correct answer...\n are you ready?\n here I go....";
        public const string introduccionNPC3 = "I will crush everything in my path.\nPrepare yourself to loss...";
        public const string introduccionNPC7 = "With my power I defeated entire legions.\n you will not be able to defeat me...";
        public const string introduccionNPC11 = "I am the king, you have no authority over me\nI will destroy you!\nYou will regret coming here";

        //constants of the items information, Name and Description
        public const string itemName0 = "armor cloak";
        public const string itemDescription0 = "A magic cloak gives you more resistance against physical damage";
        public const string itemName1 = "Dagger";
        public const string itemDescription1 = "Dagger created in the Hellrock volcano";
        public const string itemName2 = "Gold Sword";
        public const string itemDescription2 = "Sword that was created by King Midas";
        public const string itemName3 = "Gold Armor";
        public const string itemDescription3 = "It gives you protection and regeneration of life";
        public const string itemName4 = "Fire Knife";
        public const string itemDescription4 = "The knife most faster of the world, the enemies will don't know who cut them";
        public const string itemName5 = "Invisibility cloak";
        public const string itemDescription5 = "Disappears from the sight of all mortals";
        public const string itemName6 = "Sacred Arrows";
        public const string itemDescription6 = "These arrows always reach their target";
        public const string itemName7 = "Blood Crown";
        public const string itemDescription7 = "Increases the damage of all your weapons";
        public const string itemName8 = "Metal Gloves";
        public const string itemDescription8 = "Increases the power of all your blows";
        public const string itemName9 = "Power Spear";
        public const string itemDescription9 = "This spear was created by the grandmasters to defeat everyone";
        public const string itemName10 = "Dragon Blood Chains";
        public const string itemDescription10 = "An ancient dragon gave its blood to create powerful weapons";
        public const string itemName11 = "Medal of Honor";
        public const string itemDescription11 = "Give you the most importan range in the kingdom";

        //constants of the location information, Name and Description
        public const string locationName0 = "Village bakery";
        public const string locationDescription0 = "This place used to be the most visited by the entire town, a place where everyone could spend a pleasant time";
        public const string locationName1 = "Forest charming";
        public const string locationDescription1 = "someone could be nearing you, watching you.....be careful";
        public const string locationName2 = "Downtown area";
        public const string locationDescription2 = "The downtown of the city could be crazy, in specific days it is crowded.";
        public const string locationName3 = "Enchanted Mountain";
        public const string locationDescription3 = "Wonderful and mysterious creatures live in this mountain.";
        public const string locationName4 = "Forest";
        public const string locationDescription4 = "Beautiful forest, with magical creatures";
        public const string locationName5 = "Tea room";
        public const string locationDescription5 = "A particular cafe in the town";
        public const string locationName6 = "Downtown area";
        public const string locationDescription6 = "The forest meadow, where the greenest grass grows.";
        public const string locationName7 = "Entrance to the Castle";
        public const string locationDescription7 = "Anyone who wants to enter the castle must pass through this point.";
        public const string locationName8 = "Castle kitchen";
        public const string locationDescription8 = "In this place the most delicious dishes are prepared.";
        public const string locationName9 = "Castle hall";
        public const string locationDescription9 = "A very busy place in the castle.";
        public const string locationName10 = "Main room";
        public const string locationDescription10 = "A place where they met to make the most important decisions of the kingdom.";
        public const string locationName11 = "King's Room";
        public const string locationDescription11 = "Place where the king lives.";

        //constants of character information, name and description
        public const string characterName0 = "Renafh";
        public const string characterDescription0 = "Baker of the village";
        public const string characterName1 = "Wisel";
        public const string characterDescription1 = "whisper of the forest";
        public const string characterName2 = "Rick";
        public const string characterDescription2 = "A little boy";
        public const string characterName3 = "Destroyer";
        public const string characterDescription3 = "The strongest giant of the montains, expert warrior, he has a great ax instead of his left arm, he lost his arm in a battle against a dragon.";
        public const string characterName4 = "Allaf";
        public const string characterDescription4 = "Dwarf boss\r\nruler of the forest dwarves";
        public const string characterName5 = "Happy";
        public const string characterDescription5 = "happiest man, he loves coffee";
        public const string characterName6 = "Hawk";
        public const string characterDescription6 = "I'm the watch of the forest from the beginning";
        public const string characterName7 = "Bruskar";
        public const string characterDescription7 = "goblin warrior\r\nThe most powerful warrior of the tribe. He will do everything to defend the treasure he has accumulated.";
        public const string characterName8 = "Frango";
        public const string characterDescription8 = "village cook";
        public const string characterName9 = "James";
        public const string characterDescription9 = "King's guardian";
        public const string characterName10 = "Hugo";
        public const string characterDescription10 = "king's butler";
        public const string characterName11 = "Diabolic king";
        public const string characterDescription11 = "The king possessed by darkness, A demon with the help of a dragon cast a great spell on the king, dragging him into the darkness...";

        //Questions and Answers QuestionNPC
        public const string question1 = "What has a face and two hands but no arms or legs?";
        public const string answer1 = "clock";
        public const string question2 = "What has a thumb and four fingers but is not alive?";
        public const string answer2 = "glove";
        public const string question3 = "What must be broken before you can use it?";
        public const string answer3 = "egg";
        public const string question4 = "What goes up and doesn't come back down?";
        public const string answer4 = "age";        

        //GameTitle
        public const string gameTitle = @"

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
            ";

        //DescriptionGame
        public const string descriptionGame = "Some years ago Restland was a wonderful place to live, the king was fair, kindest, and he live for the kingdom.\n.........\n" +
                "but one day, the kingdom was invaded by the dark, and after months of fighting it, the king was taken into the darkness. from that day No one could see the king, no one could enter the castle again....and now the kingdom is dangerous there is a few places to feel safe, and few people to trust.\n" +
                "may the force be with you =)";

        //FinalDescription
        public const string finalDescription = "Thanks to you, peace returned to the kingdom, and we are very grateful... \nYour name will be always remembered...\nWe will never forget it.";

        //FinalMessage
        public const string finalMessage = @"
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

        ";
    }
}
