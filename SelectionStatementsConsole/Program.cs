using System;
using System.ComponentModel;

namespace SelectionStatementsConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            var rng = new Random();
            var randomNumber = rng.Next(10);



            Console.WriteLine("Welcome to the Random Number Guessing Game!!.");
            Console.Write("Please input a guess: ");

            var userNumber = int.Parse(Console.ReadLine());

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Too High!!!");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Too Low!!!");
            }
            else
            {
                Console.WriteLine("Just Right! You Win!");
            }



            Console.Write("What is your favorite coding language?");
            var userResponse = Console.ReadLine();

            switch (userResponse)
            {
                case "C#":
                    Console.WriteLine("C#: Excellent choice, that is my favorite coding language.");
                    break;

                case "Python":
                    Console.WriteLine("Python: Great language but not as good as C#");
                    break;
                case "Java":
                    Console.WriteLine("Java: Great language but not as good as C#");
                    break;
                case "Ruby":
                    Console.WriteLine("Ruby: Great language but not as good as C#");
                    break;
                case "R":
                    Console.WriteLine("R: Great language but not as good as C#");
                    break;
                default:
                    Console.WriteLine("We teach coding here....Not sure what you said.");

                    break;



            }

            }
        }
    }