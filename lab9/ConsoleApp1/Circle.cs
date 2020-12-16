//Muzyka_Milena_PD22
using System;

namespace ConsoleApp1
{
    class Circle : Shape, IDraw
    {
        private double circleRadius;
        private string name;
        public double Radius
        {
            get { return circleRadius; }
            set
            {
                //set side to 1 if the value is negative or 0
                if (value <= 0)
                {
                    circleRadius = 1;
                }
                else
                {
                    circleRadius = value;
                }
            }
        }

        public override int NumOfVertices { get { return 0; } }

        public override string Name { get { return name; } }

        public override string FigureColor { get; set; }

        public Circle(string name, string color, double radius)
        {
            this.name = name;
            FigureColor = color;
            Radius = radius;
        }
        public Circle(string name, double radius)
        {
            this.name = name;
            Radius = radius;
            FigureColor = RandomColor();
        }
        public Circle(string name)
        {
            this.name = name;
            FigureColor = RandomColor();
            Random r = new Random();
            Radius = r.Next(100);
        }

        public override double Square()
        {
            double S = Math.PI * Math.Pow(Radius, 2);
            return S;
        }

        public override double Perimeter()
        {
            double P = 2 * Math.PI * Radius;
            return P;
        }

        //interface method realisation
        public void Draw()
        {
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine("Name: {0}\nColor: {1}\nRadius: {2}\nSquare: {3}\nPerimeter: {4}", 
                Name, FigureColor, Radius, Square(), Perimeter());
            Console.WriteLine();
            Console.Write(
                           
                            "    *   * \n" +
                            "  *       *\n" +
                            " *         *\n" +
                            " *         *\n" +
                            "  *       * \n" +
                            "    *   *   \n" );
            Console.WriteLine();
            Console.WriteLine("...almost a circle:D");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
        }


    }

}
