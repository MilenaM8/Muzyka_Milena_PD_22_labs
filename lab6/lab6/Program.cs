//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");

            //checking if number is an integer
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Be aware! Enter a correct number: ");
            }

            //converting number to string
            string num = number.ToString();

            //creating a list
            List<int> numList = new List<int>();

            //filling the list 
            for (int i = 0; i < num.Length; i++)
            {
                numList.Add(int.Parse(num[i].ToString()));
            }

            numList.Sort();

            //counting each element in the list
            int counter = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                for (int j = 0; j < numList.Count; j++)
                {
                    if (numList[i] == numList[j])
                        counter++;
                }
                Console.WriteLine("Element {0} we have {1} time(s) here!", numList[i], counter);
                i += counter - 1;
                counter = 0;
            }

            //finding necessary number in the list
            Console.Write("Enter a number you want to find: ");
            int numToFind;
            while (!int.TryParse(Console.ReadLine(), out numToFind))
            {
                Console.Write("Be aware! Enter a correct number: ");
            }
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] == numToFind)
                {
                    Console.WriteLine("Your number is here at {0} position.", i+1);
                    return;
                }
            }
            Console.WriteLine("No {0} in this list!", numToFind);

        }
    }
}
