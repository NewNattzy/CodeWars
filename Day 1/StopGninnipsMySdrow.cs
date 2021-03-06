/*
    This Task from https://www.codewars.com
    Write a function that takes in a string of one or more words,
    and returns the same string, but with all five or more letter words reversed
    (Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
    Spaces will be included only when more than one word is present.
*/

using System;


public class Kata
{

    public static string SpinWords(string sentence)
    {

        string result = "";
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var word in words)
        {

            if (word.Length > 4)
                for (var i = word.Length - 1; i >= 0; i--)
                    result += word[i];
            
            else
              result += word;

            result += " ";

        }

        return result.TrimEnd();

    }
    
}


/*
    Someone else's decision  \/  impressive..

    public static string SpinWords(string sentence)
    {
        return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
    }    
*/
