/*
    Who likes it? -> Task from https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp (BattleRattle)
    You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items.
    We want to create the text that should be displayed next to such an item. Implement the function which takes an array containing
    the names of people that like an item. It must return the display text as shown in the examples:

    []                                -->  "no one likes this"
    ["Peter"]                         -->  "Peter likes this"
    ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
    ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
    ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
*/

using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {

            Likes(new string[0]);
            Likes(new string[] { "Peter" });
            Likes(new string[] { "Jacob", "Alex" });
            Likes(new string[] { "Max", "John", "Mark" });
            Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });

            Console.ReadLine();

        }

        private static string Likes(string[] name)
        {

            switch (name.Length)
            {
                case 0:
                    return $"no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";

                default:
                    return $"{name[0]}, {name[1]} and {name.Length-2} other like it!";
            }

        }

    }

}
