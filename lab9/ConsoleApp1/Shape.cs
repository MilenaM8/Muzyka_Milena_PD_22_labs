//Muzyka_Milena_PD-22
using System;
using System.Drawing;

namespace ConsoleApp1
{
    abstract class Shape 
    {

        public abstract string Name { get; }
        public abstract string FigureColor { get; set; }
        public abstract int NumOfVertices { get;}

        public abstract double Square();
        public abstract double Perimeter();      

        //generate and returns random color in string
        protected string RandomColor()
        {
            //generate random color
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            return randomColor.Name;
        }
    }
}
