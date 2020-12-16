//Muzyka__Milena PD-22
using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Extension methods ~~~");

            Console.WriteLine("\nReversing int");
            int num = 123456789;
            Console.WriteLine(num);
            num.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nReversing string");
            string str = "Hello, World!";
            Console.WriteLine(str);
            str.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nReversing double");
            double dNum = 123.567;
            Console.WriteLine(dNum);
            dNum.Reverse();
            Console.WriteLine();

            //reverse array
            Console.WriteLine("\nReversing int array");
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.Reverse();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //replace negatives by max
            Console.WriteLine("\nReplacing");
            int[] negArr = { 1, 2, -5, 10, -77, 0, 99 };

            negArr.ReplaceNegatives();
            
            for (int i = 0; i < negArr.Length; i++)
            {
                Console.Write(negArr[i] + " ");
            }
            Console.WriteLine();


        }
    }

    public static class IntExtensionMethods
    {
        //for int
        public static void Reverse(this int num)
        {

            Console.Write(num % 10);
            while ((num /= 10) != 0) {

                Console.Write(num % 10);
            }
        }
        //for string
        public static void Reverse(this string str)
        {
            char[] strArr = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
        }
        //for double
        public static void Reverse(this double dNum)
        {
            string[] splitedStr = dNum.ToString().Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
        }
        //for int array
        public static void Reverse(this int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;

                left++;
                right--;
            }
        }
        //replacing negative elements by the max in int array
        public static void ReplaceNegatives(this int[] negArr)
        {
            
            int max = negArr[0];//assign the first element to the maximum

            for (int i = 1; i < negArr.Length; i++)//finding the max
            {
                if (negArr[i] > max)
                {
                    max = negArr[i];
                }
            }

            //replacing
            for (int i = 0; i < negArr.Length; i++)
            {
                if(negArr[i] < 0)
                {
                    negArr[i] = max;
                }
            }

        }

    }

}
