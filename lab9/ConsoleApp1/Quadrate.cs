//Muzyka_Milena_PD-22
using System;

namespace ConsoleApp1
{
    class Quadrate : Shape, IDraw
    {
        private double sideA;
        private string name;
        public double Side
        {
            get { return sideA; }
            set
            {
                //set radius to 1 if the value is negative or 0
                if (value <= 0)
                {
                    sideA = 1;
                }
                else
                {
                    sideA = value;
                }
            }
        }

        public override int NumOfVertices { get { return 4; } }

        public override string Name { get { return name; } }

        public override string FigureColor { get; set; }

        public Quadrate(string name, string color, double side)
        {
            this.name = name;
            FigureColor = color;
            Side = side;
        }
        public Quadrate(string name, double side)
        {
            this.name = name;
            Side = side;
            FigureColor = RandomColor();
        }
        public Quadrate(string name)
        {
            this.name = name;
            FigureColor = RandomColor();
            Random r = new Random();
            Side = r.Next(100);
        }

        public override double Square()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 2 * (Side + Side);
        }

        //interface method realisation
        public void Draw()
        {
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine("Name: {0}\nColor: {1}\nSide: {2}\nSquare: {3}\nPerimeter: {4}",
                Name, FigureColor, Side, Square(), Perimeter());
            Console.WriteLine();
            Console.Write(
                            "   * * * * * *\n" +
                            "   *         *\n" +
                            "   *         *\n" +
                            "   *         *\n" +
                            "   *         *\n" +
                            "   * * * * * *\n");
            Console.WriteLine();
            Console.WriteLine("It's trully a Quadrate!!!");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
        }


    }

}
