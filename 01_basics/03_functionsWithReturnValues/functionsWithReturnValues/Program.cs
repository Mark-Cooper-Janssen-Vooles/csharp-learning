using System;

namespace functionsWithReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {
                //we are setting the value of name to the value that WriteTryAgain returns.
                name = TryAgain();
            }

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            if (age == "")
            {
                age = TryAgain();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine().ToLower();

            if (month == "")
            {
                month = TryAgain();
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
        //changed from void to string, meaning it can return a string.
        // our function name no longer best describes what its doing
        // can rename by right-clicking an selecting 'rename'.
        //it will change all the function calls too!
        static string TryAgain()
        {
            Console.WriteLine("You didn't type anything, please try again.");
            //whatever we return we can pass from our function and out of it.
            return Console.ReadLine();
        }
    }
}
