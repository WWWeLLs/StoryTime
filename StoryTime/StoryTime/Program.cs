using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //STORY CHARACTER VARIABLES
            String chFName;
            chFName = "Anonayah";

            String chLName;
            chLName = "Littlebird";

            String pName;
            pName = "Littlebirds";

            String princess;
            princess = "Wenonah";

            int eleNum = 5;

            String element1;
            element1 = "Earth";

            String element2;
            element2 = "Water";

            String element3;
            element3 = "Fire";

            String element4;
            element4 = "Air";

            String element5;
            element5 = "DarkLight";

            //STORY BODY VARIABLES
            String fairyTale;
            fairyTale = "Would you like to hear the story about a Princess who became Queen by the strength of her people?";
            String fairyTaleb;
            fairyTaleb = "Can you guess what the 5 elements of Nature Medallions are?";
            String fairyBodya;
            fairyBodya = "This is the story about the legend of The";
            String fairyBodyb;
            fairyBodyb = "In Native American legend, it was told that in order for the Princess to become Queen she had to live through a ceremony where her heart internally embraces the elements of Nature medallions;";
            Console.WriteLine("Welcome to the book store of Ancient Legends! What is your name?");
            Console.WriteLine("Hello my name is {0}{1}", chFName, chLName);
            Console.WriteLine("Did you say {0}?", chLName);
            Console.WriteLine(fairyTale);
            String answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", fairyBodya, pName, fairyBodyb, eleNum);
            }
            Console.WriteLine(fairyTaleb);

            String question = Console.ReadLine();
            if (question == "What is the 1st element of Nature?")
            {
                Console.WriteLine("The Warrior has to defeat the soil eaters, to acquire the medallion of {0}", element1);
            }

            else if (question == "What is the 2nd element of Nature?")
            {
                Console.WriteLine("The Warrior has to swim faster than the dolphin oracle to acquire the medallion of {0}", element2);
            }

            else if (question == "What is the 3rd element of Nature?")
            {
                Console.WriteLine("The Warrior must stop the volcanic lava flow to acquire the medallion of {0}", element3);
            }
            else if (question == "What is the 4th element of Nature?")
            {
                Console.WriteLine("The Warrior has to fly to highest peak of the mountain top to acquire the medallion of {0}", element4);
            }
            else if (question == "What is the 5th element of Nature?")
            {
                Console.WriteLine("The Warrior has to fight the knights of light and rescue the children of the darkness to acquire the medallion of {0}", element5);
            }
            else
            {
                Console.WriteLine("If the Princess doesn't embrace all medallions she will never become the Queen of Harmony & Balance over the land. The Princess name is {0}, {1}", pName, princess);
            }

            String fairyTaled;
            fairyTaled = "If I give you this book to read, will you become the Warrior for your Queen?";
            { 
            Console.WriteLine(fairyTaled);
            }
            String answera = Console.ReadLine();
            if (answera == "Yes")
            {
                Console.WriteLine("GoodLuck on your Journey {0},{1}", chFName, chLName);
            }
            else 
            {
                Console.WriteLine("Take Care {0},{1}", chFName, chLName);
            }

        }
    }
}


