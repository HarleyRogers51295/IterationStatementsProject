using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE Create a List called "numbers"
            List<int> numbers = new List<int>();
            //DONE Create a variable of type int with an initializer of 0
            int i = 0;


            do                          // DONE Create a do-while loop
            {
                i++;                  // DONE Increment your variable by 1
                numbers.Add(i);       // DONE Then add your variable to "numbers"
            } while (i < 100);
                                      // DONE While your variable is less than 100



            // DONE Create a while loop
            while (i < 200)// DONE While your variable is less than 200
            {
                i++;// DONE  Increment your variable by 1
                numbers.Add(i);// DONE Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // DONE Create a foreach loop
            // DONE  Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // DONE Create a for loop
            // DONE in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // DONE and as long as i is greater than or equal to 0
            // DONE Decrement i by 1
            for(i = 199; i <= numbers.Count && i >= 0; i--  )//For lists you have to use Count
            {
                Console.WriteLine($"the number {numbers[i]} is at index {i}."); // Write to the console "numbers" at index i
            }
        }
    }
}
