using System;
namespace interfaces
{
    //something to keep in mind: You can only inherit from one class (in this case Member), but you can inherit from multiple interfaces (i.e. IPayee).
    public class Principal : Member, IPayee
    {
		public void Pay()
		{
			Console.WriteLine("paying principal");
		}
    }
}
