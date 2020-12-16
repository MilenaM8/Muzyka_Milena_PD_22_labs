//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            Console.WriteLine("***** WELCOME TO YOUR GARAGE, MISTER *****");
            int choice;
            do
            {
                Console.WriteLine();
                if (myGarage.myCars.Count == 0)
                { 
                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[0] - close the garage. You don't want to ride today)))");
                }
                else
                { 
                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[2] - show all my cars");
                    Console.WriteLine("[3] - delete a car");
                    Console.WriteLine("[4] - find cars by one characteristic");
                    Console.WriteLine("[0] - close the garage and go for a drive with beautiful girls");
                }
                Console.Write("Chose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myGarage.AddNewCar();
                        Console.WriteLine("Car was added");
                        Console.WriteLine(myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.DisplayAllCars();
                        break;
                    case 3:
                        myGarage.RemoveCar();
                        break;
                    case 4:
                        Console.WriteLine("Okay, which characteristic would you like to find?");
                        char characteristic;
                        Console.WriteLine("[n] - name");
                        Console.WriteLine("[c] - color");
                        Console.WriteLine("[s] - speed");
                        Console.WriteLine("[y] - year of issue");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("Garage closed. Have a nice day!");
                        return;
                    default:
                        Console.WriteLine("INCORRECT OPTION!");
                        break;
                }
            } while(choice != 0);
        }
    }
}
