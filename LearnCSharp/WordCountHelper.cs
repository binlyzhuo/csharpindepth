using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LearnCSharp
{
    public class WordCountHelper
    {
        public static Dictionary<string, int> CountWords(string txt)
        {
            Dictionary<string, int> frequencies;
            frequencies = new Dictionary<string, int>();
            string[] words = Regex.Split(txt, @"\W+");
            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }

        public static void TestCount()
        {
            string txt = @"Do you like green eggs and ham?
                          I do not like them,sam-I-am.
                          I do not like green eggs and ham.";

            var frequencies = CountWords(txt);
            foreach (var entity in frequencies)
            {
                string word = entity.Key;
                int count = entity.Value;
                Console.WriteLine("{0}:{1}",word,count);
            }
        }
    }
}
