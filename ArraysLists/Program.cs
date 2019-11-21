using System;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3,7,9,2,14,6};

            // Length

            Console.WriteLine(numbers.Length);

            // IndexOf()

            int index = Array.IndexOf(numbers,9);
            Console.WriteLine(index);

            // Clear()

            Array.Clear(numbers,0,2);

            Console.WriteLine("Clear effect:");
            foreach (var number in numbers){
                Console.WriteLine(number);
            }
        }



    }
}
