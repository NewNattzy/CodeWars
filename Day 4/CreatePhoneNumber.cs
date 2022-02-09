/*
    Create Phone Number -> Task from https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp (xDranik)

    Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    The returned format must be correct in order to complete this challenge.
    Don't forget the space after the closing parentheses!

    Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
*/


using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // => returns "(123) 456-7890"

            Console.WriteLine(CreatePhoneNumber(number));
        }


        public static string CreatePhoneNumber(int[] n)
        {
            return $"{n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
        }

    }

}
