using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("scriptjavx", "javascript"));
            Console.ReadLine();

        }

        public static bool Scramble(string str1, string str2)
        {
            return str2.OrderBy(p => p).ToString().IndexOfAny(str1.OrderBy(p => p).ToArray())>=0;
            
        }
    }
}
