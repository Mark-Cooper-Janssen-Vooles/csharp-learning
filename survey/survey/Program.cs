using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


			Console.WriteLine("How old are you?");
			var age = Console.ReadLine();
			Console.WriteLine("What month were you born in?");
			var month = Console.ReadLine().ToLower();

			Console.WriteLine($"Your name is: {name}, your age is: {age}, your month of birth is: {month}.");

            Console.WriteLine("Your name is {0}, your age is {1}", name, age);

            if(month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if(month == "april")
            {
                Console.WriteLine("You are a taurus.");
            }
            else if(month == "may")
            {
                Console.WriteLine("You are a gemini.");
            }
        }
    }
}
