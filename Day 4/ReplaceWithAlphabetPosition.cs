/*
    Replace With Alphabet Position -> Task from https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp (MysteriousMagenta)

    In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    If anything in the text isn't a letter, ignore it and don't return it.

    Example
    Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
    Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string )
*/

using System;
using System.Linq;
using System.Collections.Generic;


namespace CodeWars
{

    public class Program
    {

        private static List<char> alphabet = new List<char>();

        static void Main(string[] args)
        {
            SetAlphabet();
            AlphabetPosition("!The sunset sets at twelve o' clock.");
        }


        public static string AlphabetPosition(string text)
        {
            string result = String.Empty;

            foreach (char c in text.ToUpper())
                result += alphabet.IndexOf(c) + 1 + " ";

            return result.Replace(" 0", "").Trim('0').Trim();
        }


        private static void SetAlphabet()
        {
            for (int i = 65; i < 91; i++)
                alphabet.Add((char)i);
        }

    }

}

/*
    Better solution \/ not my
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
*/
