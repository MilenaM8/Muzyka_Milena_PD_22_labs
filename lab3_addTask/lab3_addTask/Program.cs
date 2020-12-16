//Muzyka_Milena_PD-22
using System;

namespace lab3_addTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Additional task
            //Дані координати (як цілі від 1 до 8) двох різних полів шахівниці. 
            //Якщо тура за один хід може перейти з одного поля на інше, вивести логічне значення True, інакше вивести значення False. 


            int x1, y1, x2, y2;
            Console.WriteLine("Coordinates can be in range [1;8]");
            Console.WriteLine("Enter first point");
            x1 = Input("x1");
            y1 = Input("y1");

            Console.WriteLine("Enter second point");
            x2 = Input("x2");
            y2 = Input("y2");


            Console.WriteLine("\n({0};{1}) --- ({2};{3})", x1, y1, x2, y2);
            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static int Input(string coordinate)
        {
            int x;
            Console.Write("{0} = ", coordinate);
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 8)
            {
                Console.Write("Enter a correct number: ");
            }
        
            return x;
        }
    }
}

