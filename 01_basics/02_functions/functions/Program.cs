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
                WriteTryAgain();
                name = Console.ReadLine();
            }

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            if (age == "")
            {
                WriteTryAgain();
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine().ToLower();

            if (month == "")
            {
                WriteTryAgain();
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

        //first function:
        static void WriteTryAgain()
        {
            Console.WriteLine("You didn't type anything, please try again.");
        }

        //we had to write WriteTryAgain outside of main.
        //Main is a function aswell. It returns a void (or nothing), but it takes in an array of strings called args (or arguments). If you were to run the app from the terminal, something like "myapp.exe add 1 2", the arguments would be "add", "1" and "2". Add would have index 0 etc.
        //main is the entry point of your application, the first function that gets called when your application runs. And you can only have one of them. 
    }
}
