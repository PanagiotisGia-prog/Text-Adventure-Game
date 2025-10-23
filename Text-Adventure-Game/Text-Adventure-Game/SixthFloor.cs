using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class SixthFloor
    {
        public SixthFloor()
        {
            
        }
        public void sixthFloor()
        {
            Console.WriteLine("This is it! the sixth and final floor.");
            Console.WriteLine("The last riddle.");
            Console.WriteLine("After you solve this one you'll manage to face the Wizard Bugger.");
            Console.WriteLine("You take a minute to catch yor breath and clear your mind, and then you starting reading the last riddle: ");
            Console.WriteLine("I am where the earth and sky appear to meet, always out of reach. I flee as you approach, yet I am always there. \nWhat am I?");
            Console.WriteLine("Door 1: The horizon.");
            Console.WriteLine("Door 2: A mirage.");
            Console.WriteLine("Door 3: A rainbow.");
            string? riddle6 = null;
            while (true)
            {
                riddle6 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle6))
                {
                    switch (riddle6)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("As you enter, you find a staircase.");
                            Console.WriteLine("It leads you to the next floor.");
                            Console.WriteLine("You chose the correct door! Congratulations!");
                            Console.WriteLine("You manage to solve all of the Wizard Riddles. Now it's time to put an end to his reign.");
                            Console.WriteLine("\nPress any key to continue...");
                            string? moveOn = Console.ReadLine();
                            Console.Beep();
                            Console.Clear();
                            return;

                        case "door 2":
                        case "2":
                            Console.WriteLine("You choose the second door.");
                            Console.WriteLine("As you enter, you find yourself in a chilling chamber where a revenant wails, “Runtime Error: ClassNotFound!” It binds you in chains " +
                                "of broken dependencies, dooming you to haunt a corrupted class forever.");
                            Console.WriteLine("Game Over: The Runtime Error Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 3":
                        case "3":
                            Console.WriteLine("You choose the third door.");
                            Console.WriteLine("As you enter, a wraith summoned and demands from you to solve a cryptic regex puzzle. Your pattern fails to match, and the wraith " +
                                "screeches, “Invalid escape sequence!” You’re shredded by a storm of backslashes.");
                            Console.WriteLine("Game Over: The Regex Riddle Wraith Ending!");
                            Program.gameOver = true;
                            return;

                        default:
                            Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose a door!");
                }
            }
        }

    }
}
