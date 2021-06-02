using System;

namespace sr_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var cars = new Cars();
            bool exist = true;

            string color;
            int yearOfMade = 0;
            int price = 0;
            int enginePower = 0;

            byte amount = 0;
            string tempForInput;

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("-Хотите вибрать машину по параметрах?");
            Console.WriteLine("{Yes(-Да, хочу), No(-Нет,покажите мне все машини которие у вас есть.)}");
            Console.Write("Введите y или n: ");
            Console.ForegroundColor = ConsoleColor.White;
            tempForInput = Console.ReadLine();

            if (tempForInput == "y")
            {
                while (exist)
                {
                    amount = 0;
                    color = null;
                    tempForInput = null;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("- Вы можете вибрать себе машину по таких параметрах");
                    Console.Write("{Цвет(");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("__На английском__");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("), Год производства, Цена и Мощьность двигателя} \n");
                    Console.Write("-Если ви хотите пропустить какую-то характеристику введите - \n\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите цвет желаемого авто: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    color = Console.ReadLine();
                    if (color == "-")
                        amount++;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите желаемий год производства: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else yearOfMade = Convert.ToInt32(tempForInput);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите желаемую цену: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else price = Convert.ToInt32(tempForInput);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите желаемую мощьность двигателя: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else enginePower = Convert.ToInt32(tempForInput);

                    cars.findCar(amount, color, yearOfMade, price, enginePower);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n--Мне не нравлятся ети машини хочу вибрать еще раз! ");
                    Console.WriteLine("{Yes, No(Виход из программи)}");
                    Console.Write("Введите y или n: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "y" ? true : false;
                }
            }
            else
            {
                cars.showInfoAboutCars();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                exist = false;
            }

        }
    }
}

