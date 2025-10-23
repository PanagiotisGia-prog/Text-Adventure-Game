using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class FifthFloor
    {
        public FifthFloor()
        {
            
        }
        public void fifthFloor()
        {
            Console.WriteLine("You manage to reach the fifth floor, way to go! You can do it.");
            Console.WriteLine("But let's not waste any time. The fate of coffee enjoyers relies on you.");
            Console.WriteLine("You raise you head and read the next riddle: ");
            Console.WriteLine("I am always hungry, I must always feed. The more I eat, the less I weigh. What am I?");
            Console.WriteLine("Door 1: A black hole.");
            Console.WriteLine("Door 2: A worm.");
            Console.WriteLine("Door 3: A fire.");
            string? riddle5 = null;
            while (true)
            {
                riddle5 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle5))
                {
                    switch (riddle5)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("You enter inside and then opens a swirling vortex that devours your resources. A voice whispers, “Memory leak detected!” Your strength" +
                                " fades as the tower’s RAM overflows, crashing your quest.");
                            Console.WriteLine("Game Over: The Memory Leak Vortex Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 2":
                        case "2":
                            Console.WriteLine("You choose the second door.");
                            Console.WriteLine("As you enter inside a massive ogre who roars, “Index out of bounds!” You get crushed from the Array Ogre.");
                            Console.WriteLine("Game Over: The Array Ogre Ending!");
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
