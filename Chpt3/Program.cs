using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chpt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST!!");
            PrintCount();
            Console.ReadLine();
        }

        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string,int> fequencies = new Dictionary<string, int>();
            string[] words = Regex.Split(text, @"\W");
            foreach (var word in words)
            {
                if (fequencies.ContainsKey(word))
                {
                    fequencies[word]++;

                }
                else
                {
                    fequencies[word] = 1;
                }
            }
            return fequencies;
        }

        static void PrintCount()
        {
            string text = "This is a word in the word!";
            var frequencies = CountWords(text);
            foreach (var entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}:{1}",word,frequency);
            }
        }
    }
}
