/*
    Deodorant Evaporator -> Task from https://www.codewars.com/kata/5506b230a11c0aeab3000c1f/train/csharp (g964)
    We know the content of the evaporator (content in ml), the percentage of foam or gas lost every day (evap_per_day)
    and the threshold (threshold) in percentage beyond which the evaporator is no longer useful. All numbers are strictly positive.
    The program reports the nth day (as an integer) on which the evaporator will be out of use.
*/

using System;


namespace CodeWars
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(evaporator(10, 10, 5));   // 29
            Console.WriteLine(evaporator(10, 10, 10));  // 22

            Console.ReadLine();
        }

        private static int evaporator(double content, double evap_per_day, double threshold)
        {
            int days = 0;
            double temp = content * threshold / 100;

            for (; content > temp; days++)
                content -= content * evap_per_day / 100;

            return days;
        }

    }

}
