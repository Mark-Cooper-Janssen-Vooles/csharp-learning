using System;

namespace _06_events
{
    class Program
    {
        static public event Action Posted;

        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();

            var newData = new SurveyData();

            Console.WriteLine("What is your name?");
            newData.Name = TryAnswer();

            Console.WriteLine("How old are you?");
            newData.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            newData.Month = TryAnswer();

            if(Posted != null)
                Posted();

            newData.displayData();
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
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