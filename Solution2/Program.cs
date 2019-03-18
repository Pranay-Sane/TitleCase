using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TitleCase("I'm a little tea pot."));
        }

        static string TitleCase(string str)
        {
            string[] words = str.ToLower().Split(' ');
            var result = words.Select(
                val => val.Replace(
                    val[0].ToString(),
                    val[0].ToString().ToUpper()
                ));
            return String.Join(" ", result);
        }
    }
}
