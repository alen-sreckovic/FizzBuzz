/*
 * "FizzBuzz", v0.1
 * Author: Alen Sreckovic
 * Date: March 12, 2020
 * .NET Core SDK version 3.1.102
 * .NET Core Runtime version 3.1.2
 */

using System;

/*
 * A console application which iterates over a range of numbers, as dictated
 * by the user, and displays multiples of 3 as "Fizz", multiples of 5 as
 * "Buzz", and multiples of both 3 and 5 as "FizzBuzz".
 */
namespace FizzBuzz
{
    class MainClass
    {
        //All logic is handled within the main method.
        public static void Main(string[] args)
        {
            //This boolean is used to break the do-while loop under cetrain conditions.
            Boolean cont = true;

            //This system variable is used to close the application, per the user's request.
            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Welcome to FizzBuzz, by Alen Sreckovic, v0.1");
            Console.WriteLine("--------------------------------------------");

            do
            {
                try
                {

                    Console.WriteLine("Please enter first number: ");
                    int firstNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter second number: ");
                    int secondNo = Convert.ToInt32(Console.ReadLine());

                    //Checks that value-based conditions have been met by the user's input.
                    if (firstNo > secondNo || firstNo < 0 || secondNo > 150 || firstNo == secondNo)
                    {

                        Console.WriteLine("Please try again. Numbers must range from 0 to 150\n" +
                            "and the first number must be of a lesser value than the second number.\n");

                    } else { 
     
                            for (int i = firstNo; i <= secondNo; i++)
                            {
                                if (i % 3 == 0 && i % 5 == 0)
                                {
                                    Console.WriteLine("FizzBuzz");
                                }
                                else if (i % 5 == 0)
                                {
                                    Console.WriteLine("Buzz");
                                }
                                else if (i % 3 == 0)
                                {
                                    Console.WriteLine("Fizz");
                                }
                                else
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        Console.WriteLine();
                           } 
                }
                //Try-catch block checks that the user is inputting only whole numbers.
                catch (FormatException) 
                {
                    Console.WriteLine("Invalid input. Please utilise whole numbers only.\n");
                    cont = true;
                }

                Console.Write("Press Enter to try again or press 'x' to exit \n");

                consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.Key == ConsoleKey.X)
                {
                    cont = false;
                }

            } while (cont);
            
            Environment.Exit(0);
        }
    }
}
