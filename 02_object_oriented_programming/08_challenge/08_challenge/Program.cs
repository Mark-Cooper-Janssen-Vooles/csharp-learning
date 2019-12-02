using System;

namespace functionsWithReturnValues
{
	class Program
	{
		static void Main(string[] args)
		{

            var newData = new SurveyData();

			Console.WriteLine("What is your name?");
			newData.Name = TryAnswer();

			Console.WriteLine("How old are you?");
			newData.Age = int.Parse(TryAnswer());

			Console.WriteLine("What month were you born in?");
			newData.Month = TryAnswer();

            newData.displayData();
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

    class SurveyData
    {
        public string Name;
        public int Age;
        public string Month;

        public void displayData()
        {
            Console.WriteLine($"Your name is: {Name}, your age is: {Age}, your month of birth is: {Month}.");

            switch (Month)
            {
                case "march":
                    Console.WriteLine("You are an Aries");
                    break;
                case "april":
                    Console.WriteLine("You are a taurus.");
                    break;
                case "may":
                    Console.WriteLine("You are a gemini.");
                    break;
            }
        }
    }
}