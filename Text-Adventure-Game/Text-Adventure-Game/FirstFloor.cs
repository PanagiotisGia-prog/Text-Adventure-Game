using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class FirstFloor
    {
        public FirstFloor()
        {
            
        }

        public void firstFloor()
        {
            Console.WriteLine("You've arrived at the tower.");
            Console.WriteLine("As you enter,  you come across 3 doors in front of you.");
            Console.WriteLine("Above them you see a huge sign with a riddle written on it:");
            Console.WriteLine("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?\r\n\r\n");
            Console.WriteLine("You see that each door has a small sign with a different answer.");
            Console.WriteLine("Door 1: A shadow.");
            Console.WriteLine("Door 2: An echo.");
            Console.WriteLine("Door 3: A dream.");
            Console.WriteLine("Which door is the correct one?");
            Console.WriteLine("One advice form the dev: Just type the door you choose. Example: \"door 1\" or \"1\" no need to right the whole answer.");
            string? riddle1 = null;
            while (true)
            {
                riddle1 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle1))
                {
                    switch (riddle1)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("As you enter, you find a room with unlimited uncentered <divs>.");
                            Console.WriteLine("You try to center as many as you can, but there is no end.");
                            Console.WriteLine("You spend the rest of your life trying to center all the <divs> with no avail.");
                            Console.WriteLine("Game Over: The <div> Ending!");
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
                            Console.WriteLine("You choose the third door.");
                            Console.WriteLine("As you enter, you find a mirror.");
                            Console.WriteLine("Suddenly, the mirror starts to project spoilers from all your favorite series, anime, games.");
                            Console.WriteLine("That makes you so underwhelmed and demotivated that you leave the tower without caring about the quest anymore.");
                            Console.WriteLine("Game Over: The Spoiler Ending!");
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
