using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class SecondFloor
    {
        
        public SecondFloor()
        {

        }
        public void secondFloor()
        {
            Console.WriteLine("You are now on the second floor of the tower.");
            Console.WriteLine("Once again you have 3 doors and the riddle written above them: ");
            Console.WriteLine("I am taken from a mine and shut up in a wooden case, from which I am never released, and yet I am used by many. What am I?");
            Console.WriteLine("Door 1: Gold.");
            Console.WriteLine("Door 2: Pencil lead.");
            Console.WriteLine("Door 3: Ink.");
            string? riddle2 = null;
            while (true)
            {
                riddle2 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle2))
                {
                    switch (riddle2)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("You enter and tumble into a dark pit. A ghostly voice cackles, You tried to access an object that doesn't exist! NullPointerException!" +
                                " You’re trapped forever in a void of undefined references.");
                            Console.WriteLine("Game Over: The NullPointerException Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 2":
                        case "2":
                            Console.WriteLine("You choose the second door.");
                            Console.WriteLine("As you enter, you find a staircase.");
                            Console.WriteLine("It leads you to the next floor.");
                            Console.WriteLine("You chose the correct door! Congratulations!");
                            Console.WriteLine("\nPress any key to continue...");
                            string? moveOn = Console.ReadLine();
                            Console.Beep();
                            Console.Clear();
                            return;

                        case "door 3":
                        case "3":
                            Console.WriteLine("You choose the third door");
                            Console.WriteLine("You enter inside and you end up in a maze that loops endlessly. A sign reads, while(true) { suffer(); }. " +
                                "You wander in circles, unable to break free.");
                            Console.WriteLine("Game Over: The Infinite Loop Ending!");
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
