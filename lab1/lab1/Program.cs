//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            try
            {
                int seconds = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("In {0} seconds we have: {1} hours, {2} minutes, {3} seconds.", seconds, seconds / 60 / 60, seconds / 60 % 60, seconds % 60);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
