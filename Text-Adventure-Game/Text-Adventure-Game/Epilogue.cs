using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    public class Epilogue
    {
        public Epilogue()
        {
            
        }
        public void epilogue()
        {
            Console.WriteLine("You passed all the floors, answered all the riddles and now it's time to challenge the wizard.");
            Console.WriteLine("You enter his chamber and he was standing before you.");
            Console.WriteLine("Wizard: So manage to solve all of my riddles, good job. But unfortunately your journey ends here.");
            Console.WriteLine("He strikes lighting at you but you manage to dodge it.");
            Console.WriteLine("He prepares to strike you again.");
            Console.WriteLine("But you run to him and seconds before he releases his spells you cut him with your debugger sword");
            Console.WriteLine("Wizard: NOOOO...IMPOSSIBLE!");
            Console.WriteLine("The Evil Wizard Bugger was defeated and with him all of his plans to eliminate the caffeine.");
            Console.WriteLine("As you return back to the kingdom the king welcomes you as the hero and savior of caffeine and the programmers");
            Console.WriteLine("He gifts you the golden mug and throw a big celebration.");
            Console.WriteLine("Of course after that you'll have to return to your usual routine of debugging projects but at least you will have your \ncoffee.");
            Console.WriteLine("\n\t\t\t\t\t\t~~~~~~THE END!~~~~~~");
            Console.WriteLine("\nPress any key to continue...");
            string? moveOn = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("\nThank you for playing my Text Adventure Game.");
            Console.WriteLine("\nThis game was written in Visual Studio in C# (.Net).");
            Program.gameOver = true;
        }

    }
}
