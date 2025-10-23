using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class Intro
    {
        public Intro()
        {
            
        }
        public void intro()
        {
            string? username = null;
            while (true)
            {
                username = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(username))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a Username");
                }
            }
            Console.WriteLine($"{username}, you've been chosen to defeat the Evil Wizard Bugger.");
            Console.WriteLine("He's been terrorizing our Kingdom for many years with his evil spells.");
            Console.WriteLine("And this time, he's planning to release his worst spell that humanity ever seen.");
            Console.WriteLine("The Caffeine Destroyer.");
            Console.WriteLine("Well, if it wasn't clear by the name, it's going destroy every coffee that exists.");
            Console.WriteLine("Which means all the programmers are in danger. Think about it, they have only one enjoyment in his cruel world.");
            Console.WriteLine("Many tried to defeat him, but to no avail");
            Console.WriteLine("And the reason for this, is his tower");
            Console.WriteLine("Rumors say that his tower has seven floors");
            Console.WriteLine("On the seventh floor is where the Wizard resides.");
            Console.WriteLine("But in order to reach him, you must pass through the six other floors.");
            Console.WriteLine("Each floor has three doors and a riddle");
            Console.WriteLine("Each door showcases an answer. You have to choose the door with the correct answer and enter");
            Console.WriteLine("If you choose the correct door, you pass to the next floor, but if you choose the wrong...");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("To tell you the truth, I don't know, nobody ever returned to tell me what happened so I'm guessing something bad");
            Console.WriteLine("Anyway because this introduction is very long and probably gotten bored, it's time to start your quest");
            Console.WriteLine($"Good luck, {username}!");
            Console.WriteLine("\nPress any key to continue...");
            string? moveOn = Console.ReadLine();
            Console.Beep();
            Console.Clear();
        }
    }
}
