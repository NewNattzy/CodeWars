/*
    Find the unique number -> Task from https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp (isqua)

    There is an array with some numbers. All numbers are equal except for one. Try to find it!
    It’s guaranteed that array contains at least 3 numbers.
    findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
    findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
*/


using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {

            int[] one = { 1, 1, 1, 1, 1, 3, 1, 1, 1 };
            int[] two = { 2, 2, 2, 2, 2, 4, 2 };
            int[] three = { 5804, 8139, 5804, 5804, 5804, 5804, 5804 };
            
            Console.WriteLine(GetUnique(one));      // 3
            Console.WriteLine(GetUnique(two));     // 4
            Console.WriteLine(GetUnique(three));  // 8139

        }


        public static int GetUnique(IEnumerable<int> numbers)
        {

            return numbers.Where(x => x != numbers.OrderBy(x => x).Skip(1).First()).ToArray()[0];

        }

    }

}
