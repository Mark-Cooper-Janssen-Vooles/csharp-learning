using System;

//using "abstract classes"
//abstract classes allow us to create classes that are like a combination of interfaces and regular classes, which help with duplicate code. 
namespace _07_abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how you instantiate at creation, without an initializer?! { Width = 2 };
            var square = new Square() { Width = 2 };
            var triangle = new Triangle() { Base = 2, Height = 5 };

            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(triangle.GetArea());

            //instead of above, can write:
            square.Display();
            triangle.Display();
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }

    //aka like it inherits from shape
    class Square : Shape
    {
        public int Width;

        //public int GetArea()
        //{
        //    return Width * Width;
        //}

        //appended keyword "override"
        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        //public int GetArea()
        //{
        //    return (Base * Height) / 2;
        //}


        public override int GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}
