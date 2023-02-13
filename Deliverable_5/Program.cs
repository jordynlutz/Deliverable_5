using System;
using System.Linq.Expressions;

namespace Deliverable_5
/*
 * Name: Jordyn Lutz
 * Date: 2/13/2023
 * Description: Deliverable 5- Methods
 */
{
    internal class Program
    {

        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);

            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Boolean done = false;
            while (!done)
            {
                try
                {

                    Console.WriteLine("Enter the integer number between 5 and 15");
                    int input = int.Parse(Console.ReadLine());

                    int[] MyArray = random_array(input);

                    if (input >= 5 && input <= 15)
                    {

                        Console.WriteLine("The elements in the random array are: ");
                        foreach (int i in MyArray)
                        {
                            Console.WriteLine(i + " ");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("The sum is: " + sum(MyArray));
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Enter integer between 5 and 15");
                    }
                }

                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please type an integer");

                }
            }
        }
    }
}

