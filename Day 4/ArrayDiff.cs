/*
    Array.diff -> Task from https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp (marcinbunsch)

    Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
    It should remove all values from list a, which are present in list b keeping their order.

    Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
*/


using System;
using System.Linq;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {

            int[] first = { 3, 2, 15, 7, 7, 2, 3};
            int[] second = { 15, 1, 3 };

            GetArrayDiff(first, second);    // 2, 7, 7, 2

        }

        public static int[] GetArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }

    }

}
