//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Car
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int YearOfIssue { get; }
        
        public Car() { }
        public Car(string name, string color, int speed, int yearOfIssue)
        {
            Name = name;
            Color = color;
            Speed = speed;
            YearOfIssue = yearOfIssue;
        }
    }
}
