//Muzyka_Milena_PD-22
using System;


namespace ConsoleApp1
{

    interface IDraw
    {
        void Draw();
    }
    class Program
    {
        static void Main(string[] args)
        {

            
            Circle circle = new Circle("Circle 1");

            Quadrate quadrate = new Quadrate("Quarate 1", "blue", 25);
           

            Triangle triangle = new Triangle("Triangle 1", 10, 15);

            Picture picture = new Picture();

            picture.Add(circle);
            picture.Add(quadrate);
            picture.Add(triangle);
            picture.Add(new Quadrate("quadro", "green", 100));

            picture.Draw();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            picture.RemoveByName("Circle 1");
            picture.RemoveByArea(625);
            picture.RemoveByType(typeof(Circle));

            picture.Draw();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Painter.Draw(circle);
            Painter.Draw(quadrate);
            Painter.Draw(picture);

            
        }

    }
  
}
