using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main()
        {
            List<string> someWords = Console.ReadLine().Split().ToList();
            
            Random word = new Random();

            for (int i = 0; i < someWords.Count; i++)
            {
                int randomIndex = word.Next(0, someWords.Count);

                string temp = someWords[i];
                someWords[i] = someWords[randomIndex];
                someWords[randomIndex] = temp;

            }
            Console.WriteLine(string.Join(Environment.NewLine, someWords));
        }
    }
}
