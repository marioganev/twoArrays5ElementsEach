using System;

namespace tenArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[5];
            Console.Write("First element is: ");
            arr1[0] = int.Parse(Console.ReadLine());
            Console.Write("Second element is: ");
            arr1[1] = int.Parse(Console.ReadLine());
            Console.Write("Third element is: ");
            arr1[2] = int.Parse(Console.ReadLine());
            Console.Write("Fourth element is: ");
            arr1[3] = int.Parse(Console.ReadLine());
            Console.Write("Fifth element is: ");
            arr1[4] = int.Parse(Console.ReadLine());


            int[] arr2 = new int[5];
            Console.WriteLine("");
            Console.Write("First element is: ");
            arr2[0] = int.Parse(Console.ReadLine());
            if (arr1[0] == arr2[0])
            {
                Console.WriteLine("The first pair of numbers are equal.");
            }
            else Console.WriteLine("The first pair of numbers are NOT equal.");
            Console.Write("Second element is: ");
            arr2[1] = int.Parse(Console.ReadLine());
            if (arr1[1] == arr2[1])
            {
                Console.WriteLine("The second pair of numbers are equal.");
            }
            else Console.WriteLine("The second pair of numbers are NOT equal.");
            Console.Write("Third element is: ");
            arr2[2] = int.Parse(Console.ReadLine());
            if (arr1[2] == arr2[2])
            {
                Console.WriteLine("The third pair of numbers are equal.");
            }
            else Console.WriteLine("The third pair of numbers are NOT equal.");
            Console.Write("Fourth element is: ");
            arr2[3] = int.Parse(Console.ReadLine());
            if (arr1[3] == arr2[3])
            {
                Console.WriteLine("The fourth pair of numbers are equal.");
            }
            else Console.WriteLine("The fourth pair of numbers are NOT equal.");
            Console.Write("Fifth element is: ");
            arr2[4] = int.Parse(Console.ReadLine());
            if (arr1[4] == arr2[4])
            {
                Console.WriteLine("The fifth pair of numbers are equal.");
            }
            else Console.WriteLine("The fifth pair of numbers are NOT equal.");
        }
        }
    }

