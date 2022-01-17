/*Write a program that prints the numbers from 1 to 100. 
 * But for multiples of three print "Fizz" instead of the number 
 * and for the multiples of five print "Buzz". 
 * For numbers which are multiples of both three and five print "FizzBuzz".*/

namespace Andrzej
{

    public class Multi
    {

        static public void Main(String[] args)
        {

            Multi object1 = new Multi();
            for (int number = 1; number <= 100; number++)
            {
                Console.WriteLine(object1.FizzBuzzNumbers(number));
            }
        }
        public String FizzBuzzNumbers(int number)
        {

            if (number % 15 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return Convert.ToString(number);
        }
    }
}




