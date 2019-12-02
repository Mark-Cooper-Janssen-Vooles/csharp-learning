using System;

namespace _05_switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            //cleaner way to do the below is with a switch statement!
            //Console.WriteLine("How many years of experience do you have?");
            ////readline returns a string, and if statement checks for a number. Need to convert what readline returns into an integer (witn int.Parse())
            //var years = int.Parse(Console.ReadLine());

            //if (years == 0)
            //    Console.WriteLine("Inexperienced");
            //else if (years == 1)
            //    Console.WriteLine("Junior");
            //else if (years == 2)
            //    Console.WriteLine("Intermediate");
            //else if (years == 3)
            //    Console.WriteLine("Advanced");
            //else
            //    Console.WriteLine("Senior");


            //using switch statement:
            Console.WriteLine("How many years of experience do you have?");
            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }

        }
    }
}
