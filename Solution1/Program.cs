using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TitleCase("I'm a little tea pot."));
        }

        static string TitleCase(string str)
        {
            string[] words = str.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                result += word[0].ToString().ToUpper()
                    + word.Substring(1, word.Length - 1).ToLower();
                if (i < words.Length - 1)
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
