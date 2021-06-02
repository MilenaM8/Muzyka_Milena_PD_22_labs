using System;
using System.Collections.Generic;

namespace sr_1
{
    class Car
    {
        public List<String> colors = new List<String>();
        public int yearOfMade;
        public int price;
        public int enginePower;

        public Car(string[] colors = null, int yom = 0, int price = 0, int ep = 0)
        {
            for(var i = 0; i < colors.Length; i++)
                this.colors.Add(colors[i]);
            yearOfMade = yom;
            this.price = price;
            enginePower = ep;
        }
        public void showInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write($"Доступние цвета: ");
            foreach (var color in colors)
                Console.Write($" {color} ");
            Console.WriteLine();
            Console.WriteLine($"Год производства: {yearOfMade} год");
            Console.WriteLine($"Цена: {price}грн.");
            Console.WriteLine($"Мощьность двигателя: {enginePower}");
        }
    }
}
