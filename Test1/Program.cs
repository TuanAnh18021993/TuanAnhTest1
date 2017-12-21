using System;
using System.Linq;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberElement;
            do
            {
                Console.WriteLine("Please input number of elements in array :");
                numberElement = Convert.ToInt32(Console.ReadLine());
            } while (numberElement<2 || numberElement>Math.Pow(10,5));
            
            Console.WriteLine("Please input array : (ex: 1 2 3)");

            int[] array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < numberElement; i++)
            {
                int value = array[i];
                count++;
                i += value+1;
            }
            Console.WriteLine("Recover the Array : {0}", count);
            Console.ReadKey();
        }
    }
}