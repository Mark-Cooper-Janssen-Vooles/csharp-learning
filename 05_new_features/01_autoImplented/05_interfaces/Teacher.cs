using System;
namespace interfaces
{
    class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("paying teacher");
        }
    }
}
