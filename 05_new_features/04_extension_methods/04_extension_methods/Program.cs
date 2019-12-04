using System;

namespace functionsWithReturnValues
{
    public static class ExtensionMethods
    {
        //"this" is a keyword, sort of like a reference variale that points to itself or its own object. But it is required in order to have an extension method. Whatever we return is what our extension method returns. 
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var newData = new SurveyData();

            Console.WriteLine("What is your name?");
            newData.Name = TryAnswer();

            Console.WriteLine("How old are you?");
            //instead of using int.Parse, we can use an extension method!
            //newData.Age = int.Parse(TryAnswer());
            //since we made a class at the top "ExtensionMethods", we can do this below: 
            newData.Age = TryAnswer().toInt();

            Console.WriteLine("What month were you born in?");
            newData.Month = TryAnswer();

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