using System;
namespace interfaces
{
	class Teacher : Member, IPayee
	{
		public string Subject;

        public void Pay()
		{
			Console.WriteLine("paying teacher");
		}
	}
}
