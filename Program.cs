using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 5, 3, -58, 80 };
            double a = CalculateAverage(array);
            Console.WriteLine("Average: " + a);
            double b = GetMinimum(array);
            Console.WriteLine("Minimum: " + b);
            double c = GetMaximum(array);
            Console.WriteLine("Maximum: " + c);
            int d = GetEvenNumbers(array);
            Console.WriteLine("Even Numbers: " + d);

            int[] array2 = new int[5];

            array2[0] = 8; // adding values within array size - 5
            array2[1] = 7;
            array2[2] = 2;
            array2[3] = 3;
            array2[4] = 0;

            array2[0] = 0; //update

            // no delete function, only re-creating current array.
            
        }
        
        public static double CalculateAverage(int[] array) 
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        public static int GetMinimum(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static int GetMaximum(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }











        public static int[] GetEvenNumbers(int[] array) //парне
        {
            int[] arrayEven = new int[array.Length];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrayEven[j] = array[i];
                    j++;
                }
            }
            // one more array where to exclude 0

            return arrayEven;
        }





        public static GetPrimeNumbers(int[] array) //просте
        {
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] / 1 == array[i] || array[i] / array[i] == 1) // to check if they can be divided per 2, 3, 5, 7 (число, яке перевіряємо не повиненне ділитися на одне з цих)
                {

                }
            }
            return 0;
        }






    }
}
