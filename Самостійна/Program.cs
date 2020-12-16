using System;
namespace samrob
{
    class Program
    {
        static void Main(string[] args)
        {
            Vodka myVodka = new Vodka();
            int choice;
            do
            {
                Console.WriteLine();
                if (myVodka.nap.Count == 0)
                {
                    Console.WriteLine("[1] - add a new napoi");
                    Console.WriteLine("[0] - don't drink alcohol today");
                }
                else
                {
                    Console.WriteLine("[1] - add a new napoi");
                    Console.WriteLine("[2] - show all napois");
                    Console.WriteLine("[3] - find napoi by one characteristic");
                    Console.WriteLine("[0] - don't drink alcohol today");
                }
                Console.Write("Chose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myVodka.AddNewNapoi();
                        Console.WriteLine("Car was added");
                        Console.WriteLine(myVodka.nap.Count);
                        break;
                    case 2:
                        myVodka.DisplayAllNapois();
                        break;
                    case 3:
                        Console.WriteLine("Okay, which characteristic would you like to find?");
                        char characteristic;
                        Console.WriteLine("[e] - Excerpt");
                        Console.WriteLine("[m] - Country_made");
                        Console.WriteLine("[c] - Cost");
                        Console.WriteLine("[v] - Volume");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myVodka.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("REALLY??? OK, it is your choice. Have a nice day!");
                        return;
                    default:
                        Console.WriteLine("INCORRECT OPTION!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
