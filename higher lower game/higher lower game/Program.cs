using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low_game_2
{
    public class Highlow
    {
        public void RunHighLow()
        {



            bool playAgain = true;

            while (playAgain == true)
            {



                // declare variables

                string input;

                int guess;

                bool guessCorrect = false;

                int counter = 0;

                //declare variables, complete casting
                int number;


                //random number - difficulty modes;

                Random rng = new Random();

                Console.Write("Enter your difficulty (E,M,H): ");

                string difficulty = Console.ReadLine();



                if (difficulty.ToLower() == "e")
                {
                    number = rng.Next(1, 11);

                }
                else if (difficulty.ToLower() == "m")
                {
                    number = rng.Next(1, 101);
                }
                else
                {
                    number = rng.Next(1, 1001);
                }


                while (!guessCorrect)
                {
                    try
                    {
                        Console.Write("Enter your guess: ");
                        input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        if (guess == number)
                        {


                            Console.WriteLine("Correct number!");
                            Console.WriteLine($"You got the number in {counter} guesses!");
                            guessCorrect = true;

                        }

                        else if (guess > number)
                        {
                            Console.WriteLine("Too high!");
                        }
                        else
                        {
                            Console.WriteLine("Too low!");
                        }


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }



                }

                Console.Write("Play again!? (y/n): ");

                string again = Console.ReadLine();

                if (again.ToLower() == "y")
                {
                    playAgain = true;

                }
                else
                {
                    playAgain = false;
                }















            }
        }
    }

    public class BinarySearch
    {
        public void RunBinarySearch()
        {
            int min = 0;
            int max = 1000;

            int midpoint;
            int count = 0;
            bool guessCorrect = false;

            Console.Write("Range (1-1000) - Enter number for computer to guess: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            while (!guessCorrect)
            {
                count++;
                midpoint = (min + max) / 2;


                if (midpoint == answer)
                {

                    Console.WriteLine($"The answer was {midpoint}! I got it in {count} attempts.");
                    break;

                }

                Console.Write($"The guess is ({midpoint}), is the answer higher (h), lower (l) or correct (c)?");

                string reply = Console.ReadLine();






                if (reply.ToLower() == "h")
                {

                    min = midpoint;
                }
                else if (reply.ToLower() == "l")
                {

                    max = midpoint;



                }



            }
        }




















        internal class Program
        {
            static void Main(string[] args)
            {


                bool closeProgram = false;

                while (!closeProgram)
                {

                    Console.WriteLine("High low game (1) ~ Binary split example (2)");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {

                        case "1":
                            Console.Clear();
                            Highlow runHl = new Highlow();
                            runHl.RunHighLow();
                            break;

                        case "2":
                            BinarySearch runBinary = new BinarySearch();
                            runBinary.RunBinarySearch();
                            break;


                        default:
                            Console.WriteLine("Exiting!");
                            break;




                    }










                }






            }
        }
    }
}