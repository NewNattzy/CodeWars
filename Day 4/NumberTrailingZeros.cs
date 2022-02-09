/*
    Number of trailing zeros of N! -> Task from https://www.codewars.com/kata/52f787eb172a8b4ae1000a34/train/csharp (Ivan Diachenko)

    Write a program that will calculate the number of trailing zeros in a factorial of a given number.
    Hint: You're not meant to calculate the factorial. Find another way to find the number of zeros.

    Examples
    # 6! = 1 * 2 * 3 * 4 * 5 * 6 = 720 --> 1 trailing zero
    # 12! = 479001600 --> 2 trailing zeros
*/


using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(5));          // 1
            Console.WriteLine(TrailingZeros(12));        // 2
            Console.WriteLine(TrailingZeros(25));       // 6
            Console.WriteLine(TrailingZeros(531));     // 131
        }

        public static int TrailingZeros(int n)
        {

            int result = 0;
            int degreeOfFive = 0;
            
            for(int i = 5; n >= i; i *= 5)
            {
                result += n / i + degreeOfFive;

                if (n % i == 0 && i != 5)
                    degreeOfFive++;
            }

            return result;

        }

    }

}

/*
   Random Test Failed:
     Expected: 248323932
     But was:  248323951
*/
