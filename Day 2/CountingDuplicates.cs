/*
    Counting Duplicates -> Task from https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp (kgashok)
    Write a function that will return the count of distinct case-insensitive alphabetic characters
    and numeric digits that occur more than once in the input string. The input string can be assumed
    to contain only alphabets (both uppercase and lowercase) and numeric digits.
*/

using System;
using System.Linq;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(CountingDuplicateLetters(""));                    // 0
            Console.WriteLine(CountingDuplicateLetters("abcde"));              // 0
            Console.WriteLine(CountingDuplicateLetters("aabbcde"));           // 2
            Console.WriteLine(CountingDuplicateLetters("Indivisibility"));   // Expected: 2 | Result: 5
        }

        private static int CountingDuplicateLetters(string str)
        {

            return str.Count() - str.ToLower().Distinct().Count();

        }

    }

}
