/*
    SplitString -> Task from https://www.codewars.com (jhoffner)
    Complete the solution so that it splits the string into pairs of two characters.
    If the string contains an odd number of characters then it should replace the missin
    second character of the final pair with an underscore ('_').
*/


using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(ToString(GetLettersPair("abcdef")));
            Console.ReadKey();
        }


        public static string[] GetLettersPair(string str)
        {
            string[] lettersPair = str.Length % 2 == 0 ? new string[str.Length / 2] : new string[(str.Length + 1) / 2];

            if (str.Length % 2 != 0)
                str += "_";

            SplitLettersIntoPairs(ref lettersPair, str);

            return lettersPair;
        }


        private static void SplitLettersIntoPairs(ref string[] arr, string str)
        {
            int i = 0;
            string temp = "";

            foreach (char c in str)
            {
                temp += c;
                if (temp.Length == 2)
                {
                    arr[i++] = temp;
                    temp = "";
                }
            }
        }


        private static string ToString(string[] lettersPair)
        {
            string result = "";

            foreach (string pair in lettersPair)
                result += pair + " ";

            return result.TrimEnd();
        }

    }

}
