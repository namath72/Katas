using System;
using System.Linq;

namespace Katas
{
    
    public class Katas
    {
        //Function that receives two IPv4 addresses, 
        //and returns the number of addresses between them(including the first one, excluding the last one).
        public static long IpsBetween(string start, string end)
        {
            int[] startnet = start.Split('.').Select(n => int.Parse(n)).ToArray();
            int[] endnet = end.Split('.').Select(n => int.Parse(n)).ToArray();
            var distance = 0;
            for (var i = 0; i < 4; i++)
            {
                distance = distance + (int)Math.Pow(256, i) * (endnet[3 - i] - startnet[3 - i]);
            }
            return distance;
        }

        //Method that finds the next integral perfect square after the one passed as a parameter.
        //Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.
        public static long FindNextSquare(long num)
        {
            return Math.Sqrt(num) % 1 == 0 ? (long)Math.Pow(Math.Sqrt(num) + 1, 2) : -1;
        }

        //function that accepts a string parameter, and reverses each word in the string.
        //All spaces in the string should be retained.
        public static string ReverseWords(string str)
        {
            return String.Join(" ", str.Split().Select(w => String.Join("", w.Reverse())));
        }
    }
}
