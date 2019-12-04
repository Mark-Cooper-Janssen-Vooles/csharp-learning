using System;
namespace interfaces
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal");
        }
    }
}
