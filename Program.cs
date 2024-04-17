using System;
using System.Diagnostics;

namespace ElenarRPG
{

    class Program
    {
        public static PlayerCharacter pC = new PlayerCharacter();
        private static bool characterCreated = false;
        private static string[] c_Classes = {"Warrior", "Hunter", "Thief", "Mage"};
        private static string[] c_Races = {"Orc", "Elf", "Human", "Dwarf"};


        static void Main(string[] args)
        {
            Start();
        }
        
        static void Start()
        {

            Console.Title = "Elarian RPG";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Elarian Text RPG!");
            Console.WriteLine("This project is a pet project of mine it's available at Itchio and GitHub");
            Console.WriteLine("Feedback and bug reports are welcome! Please see below!");
            Console.WriteLine("Discord: (link unavailbe)");
            Console.WriteLine("Github: https://github.com/Shini9000 \n\nPlease wait...");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Read a quick tutorial or continue...");
            Console.WriteLine("[[H]elp] or [[C]ontinue]...");
            Console.ResetColor();
            // Check for input on opening cc or menu tutorial
            string userInput = Console.ReadLine();
            userInput = char.ToUpper(userInput[0]) + userInput.Substring(1);
            Debug.Print(userInput);
            switch (userInput) 
            {
                case "H":
                    Debug.Print("H");
                    HelpTutorial();
                    break;
                case "Help":
                    Debug.Print("Help");
                    HelpTutorial();
                    break;
                case "Continue":
                    Debug.Print("Continue");
                    CharacterCreation();
                    break;
                case "C":
                    Debug.Print("C");
                    CharacterCreation();
                    break;
                case null:
                    Debug.Print("ERROR");
                    Debug.Print(userInput);
                    // code block
                    break;
                default:
                    Debug.Print("ERROR");
                    Debug.Print(userInput);
                    // code block
                    break;
            }

            // check to see if characer is created
            if (characterCreated == false){
                Console.Clear();
                CharacterCreation();
            }

            // Writes the player profile after creation to show stats
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("---- Profile ----"
                        + "\nPlayername: " + pC.name 
                        + "\nRace: " + pC.currentRace 
                        + "\nClass: " + pC.currentClass
                        + "\nDiety: " + pC.diety
                        + "\nGold: " + pC.gold 
                        + "\nHealth: " +  pC.health 
                        + "\nEXP: " +  pC.experience 
                        + "\nAC: " +  pC.armorClass 
                        + "\nSpell Slots: " +  pC.spellSlots 
                        + "\nHealth Potions: " +  pC.healthPots 
                        + "\nBag: " +  pC.bagSpace
                        + "\nWeaponEquipped: " +  pC.weaponEquiped
                        + "\n-----------------");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("\n----- Stats -----"
                        + "\nAcrobatics: " + pC.skill_Acrobatics 
                        + "\nAgility: " + pC.skill_Agility 
                        + "\nCharisma: " + pC.skill_Charisma
                        + "\nDexterity: " + pC.skill_Dexterity
                        + "\nIntelligence: " + pC.skill_Intelligence 
                        + "\nPerception: " +  pC.skill_Perception 
                        + "\nStrength: " +  pC.skill_Strength 
                        + "\nWisdom: " +  pC.skill_Wisdom
                        + "\n---- Profile ----");

            System.Threading.Thread.Sleep(3000);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Start story!

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("It's dark but not light either it smells... odd. ");
            Console.Write("There is a shadow of sorts a little ways away it's making ");
            Console.Write("that sound again... a high pitched squeeking noise... almost like a...");
            //Encounters.FirstEncounter();

        }
            
        static void CharacterCreation()
        {

            Console.Clear();
            Console.Write("Enter your name: ");
            pC.name = Console.ReadLine();
            // check to see if input name is blank
            if (pC.name == "")
            {
                Console.WriteLine("You cant remember your name?");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                // if input name is blank then run CC again
                CharacterCreation();
            }
            // clear console and pick a race
            Console.Clear();
            Array.Sort(c_Races);
            Console.WriteLine("Now pick a race!");
            while (pC.currentRace is PlayerCharacter.playerRace.Nothing)
            {
                // will list all in c_Races as 1. 2. 3. ...
                for (int i = 0; i < c_Races.Length; i++) 
                {
                    int number = i + 1;
                    Console.WriteLine(number + ". " + c_Races[i]);
                    continue;
                }
                // inputs for race
                var s_Race = Console.ReadLine();
                if (s_Race.Length == 1)
                {
                    // checks for user input as "1" or "2"..
                    int selected_race = Convert.ToInt16(s_Race);
                    Debug.WriteLine("Chosen Int");
                    switch (selected_race)
                    {
                        case 2:
                            Console.WriteLine("You chose Elf");
                            pC.currentRace = PlayerCharacter.playerRace.Elf;
                            continue;
                        case 3:
                            Console.WriteLine("You chose Human");
                            pC.currentRace = PlayerCharacter.playerRace.Human;
                            continue;
                        case 4:
                            Console.WriteLine("You chose Orc");
                            pC.currentRace = PlayerCharacter.playerRace.Orc;
                            continue;
                        case 1:
                            Console.WriteLine("You chose Dwarf");
                            pC.currentRace = PlayerCharacter.playerRace.Dwarf;
                            continue;
                        default:
                            Console.WriteLine("Int This is not a valid race or race cant be nothing!");
                            break;
                    }
                } else {
                    // checks for user input as "elf" or "orc"...
                    s_Race = char.ToUpper(s_Race[0]) + s_Race.Substring(1); // basically formats to a cap "elf" >> "Elf"
                    Debug.WriteLine("Chosen String " + s_Race);
                    switch (s_Race)
                    {
                        case "Elf":
                            Console.WriteLine("You chose Elf");
                            pC.currentRace = PlayerCharacter.playerRace.Elf;
                            continue;
                        case "Human":
                            Console.WriteLine("You chose Human");
                            pC.currentRace = PlayerCharacter.playerRace.Human;
                            continue;
                        case "Orc":
                            Console.WriteLine("You chose Orc");
                            pC.currentRace = PlayerCharacter.playerRace.Orc;
                            continue;
                        case "Dwarf":
                            Console.WriteLine("You chose Dwarf");
                            pC.currentRace = PlayerCharacter.playerRace.Dwarf;
                            continue;
                        default:
                            Console.WriteLine("String This is not a valid race or race cant be nothing!");
                            break;
                    }
                }

            }

            // clear console and pick a profession
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\n----------\n");
            Console.WriteLine("Now pick a class!\n");
            Array.Sort(c_Classes);
            //Console.WriteLine(c_Classes);
            
            while (pC.currentClass is PlayerCharacter.playerClass.Peasant) 
            {
                // will list all in c_Races as 1. 2. 3. ...
                for (int i = 0; i < c_Classes.Length; i++) 
                {
                    int number = i + 1;
                    Console.WriteLine(number + ". " + c_Classes[i]);
                    continue;
                }
                // inputs for class
                var s_classes = Console.ReadLine();
                if (s_classes.Length == 1)
                {
                    int selected_race = Convert.ToInt16(s_classes);
                    Debug.WriteLine("Chosen Int");
                    switch (selected_race)
                    {
                        case 4:
                            Console.WriteLine("You chose Warrior");
                            pC.currentClass = PlayerCharacter.playerClass.Warrior;
                            continue;
                        case 1:
                            Console.WriteLine("You chose Hunter");
                            pC.currentClass = PlayerCharacter.playerClass.Hunter;
                            continue;
                        case 3:
                            Console.WriteLine("You chose Thief");
                            pC.currentClass = PlayerCharacter.playerClass.Thief;
                            continue;
                        case 2:
                            Console.WriteLine("You chose Mage");
                            pC.currentClass = PlayerCharacter.playerClass.Mage;
                            continue;
                        default:
                            Console.WriteLine("Int This is not a valid race or race cant be nothing!");
                            break;
                    }
                } else {

                    s_classes = char.ToUpper(s_classes[0]) + s_classes.Substring(1);
                    Debug.WriteLine("Chosen String " + s_classes);
                    switch (s_classes)
                    {
                        case "Warrior":
                            Console.WriteLine("You chose Warrior");
                            pC.currentClass = PlayerCharacter.playerClass.Warrior;
                            continue;
                        case "Hunter":
                            Console.WriteLine("You chose Hunter");
                            pC.currentClass = PlayerCharacter.playerClass.Hunter;
                            continue;
                        case "Thief":
                            Console.WriteLine("You chose Thief");
                            pC.currentClass = PlayerCharacter.playerClass.Thief;
                            continue;
                        case "Mage":
                            Console.WriteLine("You chose Mage");
                            pC.currentClass = PlayerCharacter.playerClass.Mage;
                            continue;
                        default:
                            Console.WriteLine("String This is not a valid race or race cant be nothing!");
                            break; 
                    }
                }

            }
            
            //pC.SwitchWeapon(weapons[0]);   //weapons[0] = fists.
            //pC.SwitchSpell(spells[0]);

            Console.WriteLine("CURRENT WEAPON EQUIPPED: " /*+ pC.weaponEquiped.weaponName*/);
            Console.WriteLine("Current Spell: " /*+ pC.spellSelected.spellName*/);


            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Character created!");
            Console.Clear();
            characterCreated = true;
        }


        static void HelpTutorial()
        {
            Console.Clear();
            Console.WriteLine("|TUTORIAL|\n" +
            "Key\tInfo\n" +
            " *\tThis is not part of the story but hints, tutorial or advice. \n" +
            " ||\tText in this box are to emphasis what the game is telling you |Location|, |NPC| etc. \n" +
            " -\tItems or text marked here represents what you have done \"- Picked up Iron sword\"\n" +
            " []\tText in is the games way to display buttons [Y]es, [A]ttack etc. \n\tUse either whats [in here] or the entire word!\n" +
            "Press ENTER to continue...");
            
            Console.ReadKey();

        }
    }
}