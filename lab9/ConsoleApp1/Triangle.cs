
//Muzyka_Milena_PD-22
using System;

namespace ConsoleApp1
{
    class Triangle : Shape, IDraw
    {
        private string name;
        private double triangleSide;
        private double triangleBase;
        public double Side
        {
            get { return triangleSide; }
            set
            {
                //set side of triangle to 1 if the value is negative or 0
                if (value <= 0)
                {
                    triangleSide = 1;
                }
                else
                {
                    triangleSide = value;
                }
            }
        }

        public double Base
        {
            get { return triangleBase; }
            set
            {
                //set base of triangle to 1 if the value is negative or 0
                if (value <= 0)
                {
                    triangleBase = 1;
                }
                else
                {
                    triangleBase = value;
                }
            }
        }

        public override int NumOfVertices { get { return 3; } }

        public override string Name { get { return name; } }

        public override string FigureColor { get; set; }

        public Triangle(string name, string color, double side, double tBase)
        {
            this.name = name;
            FigureColor = color;
            Side = side;
            Base = tBase;    
        }
        public Triangle(string name, double side, double tBase)
        {
            this.name = name;
            Side = side;
            Base = tBase;
            FigureColor = RandomColor();
        }
        public Triangle(string name)
        {
            this.name = name;
            FigureColor = RandomColor();
            Random r = new Random();
            Side = r.Next(100);
            Base = r.Next(100);
        }

        public override double Square()
        {
            double halfPerimeter = Perimeter() / 2;
            double S = Math.Sqrt(halfPerimeter * (halfPerimeter - Side) * (halfPerimeter - Side) * (halfPerimeter - Base));

            return S;
        }

        public override double Perimeter()
        {
            double P = Side * 2 + Base;
            return P;
        }

        //interface method realisation
        public void Draw()
        {
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine("Name: {0}\nColor: {1}\nSide: {2}\nBase: {3}\nSquare: {4}\nPerimeter: {5}", 
                Name, FigureColor, Side, Base, Square(), Perimeter());
            Console.WriteLine();
            Console.Write(
                            "          *      \n" +
                            "         * *     \n" +
                            "        * * *    \n" +
                            "       * * * *   \n" +
                            "      * * * * *  \n" +
                            "     * * * * * * \n" +
                            "    * * * * * * *\n");
            Console.WriteLine();
            Console.WriteLine("I was trying for a long...");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
        }


    }

}
