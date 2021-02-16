using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
              
            }

            for (int i = n-1; i>=0; i--)
            {
                Console.WriteLine(numbers[i]+" ");
            }
        }
    }
}
