/*
    #Find the missing letter -> Task from https://www.codewars.com (user5036852)
    Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.
    You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
*/

using System;

namespace CodeWars
{

    public class Program
    {

        private static List<char> alphabet = new List<char>();

        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Console.ReadKey();
        }


        public static char FindMissingLetter(char[] array)
        {
            SetAlphabet(ref alphabet);

            for (int i = 0; i < array.Length; i++)
                if (alphabet[i] != char.ToUpper(array[i]))
                    return alphabet[i];

            return '0';
        }


        private static void SetAlphabet(ref List<char> alphabet)
        {
            for (int i = 65; i < 91; i++)
                alphabet.Add((char)i);
        }

    }

}