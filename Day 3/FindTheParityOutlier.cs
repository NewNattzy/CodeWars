/*
    Find The Parity Outlier -> Task from https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/csharp (obnounce)
    You are given an array (which will have a length of at least 3, but could be very large) containing integers.
    The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
    Write a method that takes the array as an argument and returns this "outlier" N.
*/

using System;
using System.Linq;


namespace CodeWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 1, 3, 5, 7, 8 };                 
            int[] second = { 4, 2, 4, 6, 8, 10, 12, 40, 1 }; 

            FindAloneNumber(first);         // 8
            FindAloneNumber(second);       // 1

            Console.ReadLine();
        }


        private static int FindAloneNumber(int[] integers)
        {
            int[] evenNumbers = integers.Where(i => i % 2 == 0).ToArray();

            if (evenNumbers.Length == 1)
                return evenNumbers[0];
            else
                return Array.Find(integers, number => number % 2 == 1);
        }
    }
}
