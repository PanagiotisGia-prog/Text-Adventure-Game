namespace Text_Adventure_Game
{
    internal class Program
    {
        public static bool gameOver;

        static void Main(string[] args)
        {
            gameOver = false;
            Console.WriteLine("My Text Adventure Game.");
            Console.WriteLine("A fun adventure-puzzle game");
            Console.WriteLine("Game Title: The Tower Of Riddles.");
            Console.WriteLine("Please enter your username:");
            Intro intro = new Intro();
            FirstFloor firstFloor = new FirstFloor();
            SecondFloor secondFloor = new SecondFloor();
            ThirdFloor thirdFloor = new ThirdFloor();
            FourthFloor fourthFloor = new FourthFloor();
            FifthFloor fifthFloor = new FifthFloor();
            SixthFloor sixthFloor = new SixthFloor();
            Epilogue epilogue = new Epilogue();

            intro.intro();
            firstFloor.firstFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            secondFloor.secondFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            thirdFloor.thirdFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            fourthFloor.fourthFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            fifthFloor.fifthFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            sixthFloor.sixthFloor();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
                return;
            }
            epilogue.epilogue();
            if (gameOver)
            {
                Console.WriteLine("Thank you for playing!");
            }

            Console.ReadKey();
        }
    }
}



