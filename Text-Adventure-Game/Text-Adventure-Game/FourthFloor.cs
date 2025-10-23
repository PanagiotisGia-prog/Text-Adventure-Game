using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class FourthFloor
    {
        public FourthFloor()
        {
            
        }
        public void fourthFloor()
        {
            Console.WriteLine("You reached the fourth floor you're almost there.");
            Console.WriteLine("Without taking any break you read the next riddle:");
            Console.WriteLine("I can fly without wings, I can cry without eyes. Whenever I go, darkness follows. What am I?");
            Console.WriteLine("Door 1: A bat.");
            Console.WriteLine("Door 2: A ghost.");
            Console.WriteLine("Door 3: A cloud.");
            string? riddle4 = null;
            while (true)
            {
                riddle4 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle4))
                {
                    switch (riddle4)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("As you enter inside you come face to face with a snarling minotaur wielding a Git repository. It bellows, " +
                                "“Resolve this merge conflict!” You’re trampled under conflicting commits, lost in a version control nightmare.");
                            Console.WriteLine("Game over: The Merge Conflict Minotaur Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 2":
                        case "2":
                            Console.WriteLine("You choose the second door.");
                            Console.WriteLine("As you enter inside you meet a troll, demanding you answer StackOverflow questions without searching. Your incorrect replies enrage it," +
                                " buries under a flood of downvotes.");
                            Console.WriteLine("Game Over: The Stack Overflow Troll Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 3":
                        case "3":
                            Console.WriteLine("You choose the third door.");
                            Console.WriteLine("As you enter, you find a staircase.");
                            Console.WriteLine("It leads you to the next floor.");
                            Console.WriteLine("You chose the correct door! Congratulations!");
                            Console.WriteLine("\nPress any key to continue...");
                            string? moveOn = Console.ReadLine();
                            Console.Beep();
                            Console.Clear();
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
