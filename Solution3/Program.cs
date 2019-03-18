using System;
using System.Text.RegularExpressions;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TitleCase("I'm a little tea pot."));
        }

        static string TitleCase(string str)
        {
            return Regex.Replace(str, @"(^|\s)\S", l => l.Value.ToUpper());
        }
    }
}
