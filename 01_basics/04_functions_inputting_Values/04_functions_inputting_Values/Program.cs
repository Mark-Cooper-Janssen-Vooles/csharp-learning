using System;

namespace functionsWithReturnValues
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name?");
			var name = TryAnswer();

			Console.WriteLine("How old are you?");
			var age = TryAnswer();

			Console.WriteLine("What month were you born in?");
			var month = TryAnswer();


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

        //since we're passing in a string, we specify that type.  
		//static string TryAgain(string question)

        static string TryAnswer()
		{
            //if we add this line, our function doesn't need to be passed an argument... it has more responsibiltiy lol
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            //we always need to return something from this function, since its 'string' and not 'void' type.
            return answer;
		}

        //code is improved / optimised without changing its behaviour ... aka "refactoring" 
	}
}