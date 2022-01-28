/*
    Isograms -> Task from https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp (chunjef)
    An isogram is a word that has no repeating letters, consecutive or non-consecutive.
    Implement a function that determines whether a string that contains only letters is an isogram.
    Assume the empty string is an isogram. Ignore letter case.
*/

using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(CheckIsogram("Dermatoglyphics"));    // True
            Console.WriteLine(CheckIsogram("isogram"));           // True
            Console.WriteLine(CheckIsogram("moose"));            // False
            Console.WriteLine(CheckIsogram("moOse"));           // False
        }

        private static bool CheckIsogram(string str)
        {
            string result = string.Empty;

            foreach (char c in str.ToLower().Distinct())
                result += c;
            
            return str.ToLower() == result ? true : false;
        }

    }

}

/*
    Someone else's decision \/
    return str.ToLower().Distinct().Count()==str.Length;
*/
