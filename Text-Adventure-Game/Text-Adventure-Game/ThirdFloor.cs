using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class ThirdFloor
    {
        public ThirdFloor()
        {
            
        }
        public void thirdFloor()
        {
            Console.WriteLine("You managed to reach the third floor.");
            Console.WriteLine("3 more to face the Evil Wizard.");
            Console.WriteLine("Once again 3 doors are in your way. Only one is correct.");
            Console.WriteLine("You read the riddle above the doors: ");
            Console.WriteLine("The more you take, the more you leave behind. What am I?");
            Console.WriteLine("Door 1: Footprints.");
            Console.WriteLine("Door 2: Gold coins.");
            Console.WriteLine("Door 3: Memories.");
            string? riddle3 = null;
            while (true)
            {
                riddle3 = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrWhiteSpace(riddle3))
                {
                    switch (riddle3)
                    {
                        case "door 1":
                        case "1":
                            Console.WriteLine("You choose the first door.");
                            Console.WriteLine("As you enter, you find a staircase.");
                            Console.WriteLine("It leads you to the next floor.");
                            Console.WriteLine("You chose the correct door! Congratulations!");
                            Console.WriteLine("\nPress any key to continue...");
                            string? moveOn = Console.ReadLine();
                            Console.Beep();
                            Console.Clear();
                            return;

                        case "door 2":
                        case "2":
                            Console.WriteLine("You choose the second door.");
                            Console.WriteLine("As you enter, a spectral scribe shrieks, “Missing semicolon! Unclosed bracket!” " +
                                "Your mind unravels as you’re forced to parse garbled code for eternity, never finding the error.");
                            Console.WriteLine("Game Over: The Syntax Error Specter Ending!");
                            Program.gameOver = true;
                            return;

                        case "door 3":
                        case "3":
                            Console.WriteLine("You choose the third door.");
                            Console.WriteLine("As you enter a dragon appears in front of you and roars, “This method is deprecated!” It breathes obsolete code, turning you into a pile of outdated floppy disks." +
                                " No one supports your version anymore.");
                            Console.WriteLine("Game Over: The Deprecated Dragon Ending!!");
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
