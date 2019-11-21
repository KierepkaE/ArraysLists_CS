using System.Collections.Generic;
using System;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 9, 2, 14, 6 };

            // Length

            Console.WriteLine(numbers.Length);

            // IndexOf()

            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            // Clear()

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Clear effect:");
            foreach (var number in numbers) {
                Console.WriteLine(number);
            }

            // Copy()
            int[] arr = new int[3];
            Array.Copy(numbers, arr, 3);
            foreach (var number in arr) {
                Console.WriteLine(number);
            }

            // Sort()

            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Reverse()

            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // LISTS

            var numbers2 = new List<int>() { 1, 2, 3, 4 };
            numbers2.Add(1);
            numbers2.AddRange(new int[3] { 5, 6, 7 });
            foreach (var num in numbers2) {
                Console.WriteLine(num);
            }

            Console.WriteLine("Index of 1:" + numbers2.IndexOf(1));
            Console.WriteLine("Last index of 1:" + numbers2.LastIndexOf(1));
            Console.WriteLine("Count:" + numbers2.Count);
            numbers2.Remove(1);
            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            for (var i = 0; i < numbers2.Count; i++) {
                if (numbers2[i] == 1) {
                    numbers2.Remove(numbers[i]);
                }
            }

        }

    }
}
