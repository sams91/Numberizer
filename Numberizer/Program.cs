using System;


namespace Numberizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            Greeting();




            while (true)
            {


                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                int guess = 0;

                //Ask for number
                Console.WriteLine("Pick a number between 1 and 10");

                //while not correct
                while (guess != correctNumber)
                {
                    //get input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        EnterNumber(ConsoleColor.Yellow, "Please enter a number, 1 through 10.");

                        continue;
                    }

                    //parse 
                    guess = Int32.Parse(input);

                    //match guess
                    if (guess != correctNumber)
                    {
                        EnterNumber(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //if correct

                EnterNumber(ConsoleColor.Blue, "You are correct!!!");

                Console.WriteLine("Would you like to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Numberizer";
            string appVersion = "1.0.0";
            string appAuthor = "JA";

            Console.ForegroundColor = ConsoleColor.Green;
            //header
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void Greeting()
        {
            Console.WriteLine("What is your name?");

            //get input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void EnterNumber(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
