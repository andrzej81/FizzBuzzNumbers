﻿/*Write a program that prints the numbers from 1 to 100. 
 * But for multiples of three print "Fizz" instead of the number 
 * and for the multiples of five print "Buzz". 
 * For numbers which are multiples of both three and five print "FizzBuzz".*/

void FizzBuzzNumbers()
{
    int number = 1;
    while (number <= 100)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine(" FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine(" Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine(" Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
        number++;
    }
}

FizzBuzzNumbers();
