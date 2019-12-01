using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //if a user accidently presses enter without entering data, they have to restart the whole app.

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if(name == "")
            {
                Console.WriteLine("You didn't type in anything, please try again.");
                name = Console.ReadLine();
            }

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            if (age == "")
            {
                Console.WriteLine("You didn't type in anything, please try again.");
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine().ToLower();

            if (month == "")
            {
                Console.WriteLine("You didn't type in anything, please try again.");
                month = Console.ReadLine();
            }

            Console.WriteLine($"Your name is: {name}, your age is: {age}, your month of birth is: {month}.");

            Console.WriteLine("Your name is {0}, your age is {1}", name, age);

            if (month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month == "april")
            {
                Console.WriteLine("You are a taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("You are a gemini.");
            }
        }
    }
}
