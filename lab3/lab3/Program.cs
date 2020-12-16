//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Перевірити істинність вислову: "Дане чотиризначне число читається однаково зліва направо і справа наліво". 

namespace lab3
{
    class Program
    {
        static void Main()
        {
            int number;
            string numString;

            try
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                numString = number.ToString();
                if (numString.Length == 4)
                {
                    string reversedNumber = Reverse(numString);
                    if (numString == reversedNumber)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("There are < than 4 digits!");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


