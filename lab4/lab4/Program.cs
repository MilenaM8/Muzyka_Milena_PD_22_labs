//Muzyka_Milena_PD-22
using System;

class Program
{
    static void Main()
    {
        int n=0;
        
            try
            {
            do
            {
                Console.Write("Enter n: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n <= 2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
       
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("a{0}=",i);

            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        if (Arithmetic(arr) != 0)
        {
            Console.WriteLine("It's arithmetic progression.\nThe difference is {0}",Arithmetic(arr));
        }else if(Geometric(arr) != 0)
        {
            Console.WriteLine("It's geometric progression.\nThe denominator is {0}",Geometric(arr));
        }
        else
        {
            Console.WriteLine("0 - No progressions!");
        }
    }

    static int Arithmetic(int[] Array)
    {
        int counter = 0;
        int difference = Array[1] - Array[0];
        for (int i = 2; i < Array.Length; i++)
        {
            if (Array[i] - Array[i - 1] == difference)
                counter++;
                    
        }
        if(counter == Array.Length - 2)       
            return difference;
        
        return 0;
    }

    static int Geometric(int[] Array)
    {
        int counter = 0;
        int denominator = Array[1] / Array[0];
        for (int i = 2; i < Array.Length; i++)
        {
            if (Array[i] / Array[i - 1] == denominator)
                counter++;
        }
        if (counter == Array.Length - 2)
            return denominator;

        return 0;
    }
   
}

