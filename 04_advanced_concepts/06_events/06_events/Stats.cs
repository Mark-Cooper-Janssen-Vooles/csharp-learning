using System;
namespace _06_events
{
    public class Stats
    {
        public void Start()
        {
            Program.Posted += hasPosted;
        }

        void hasPosted()
        {
            Console.WriteLine("Survey posted. Run stats.");
        }
    }
}
