using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_8
{
    class MyDictionary
    {
        private Dictionary<string, string> EngDictionary { get; set; } = new Dictionary<string, string>();
        private Dictionary<string, string> RusDictionary { get; set; } = new Dictionary<string, string>();

        public MyDictionary()
        {
            EngDictionary.Add("Англия", "England");
            EngDictionary.Add("Франция", "France");
            EngDictionary.Add("Германия", "Germany");
            EngDictionary.Add("Россия", "Russia");
            EngDictionary.Add("США", "USA");
            EngDictionary.Add("Бразилия", "Brazil");
            EngDictionary.Add("Аргентина", "Argentina");
            EngDictionary.Add("Китай", "China");
            EngDictionary.Add("Япония", "Japan");

            RusDictionary.Add("England", "Англия");
            RusDictionary.Add("France", "Франция");
            RusDictionary.Add("Germany", "Германия");
            RusDictionary.Add("Russia", "Россия");
            RusDictionary.Add("USA", "США");
            RusDictionary.Add("Brazil","Бразилия");
            RusDictionary.Add("Argentina", "Аргентина");
            RusDictionary.Add("China", "Китай");
            RusDictionary.Add("Japan", "Япония");
        }

        public string Translate(string word)
        {
            string translateValue = null;
            if (EngDictionary.ContainsKey(word))
            {
                EngDictionary.TryGetValue(word, out translateValue);
            }
            else
            {
                RusDictionary.TryGetValue(word, out translateValue);
            }

            return translateValue;
        }


    }

    class WordCounter
    {
        private Dictionary<string, int> WordCounterDictionary { get; set; } = new Dictionary<string, int>();

        public void Run(string innerString)
        {
            innerString = innerString.TrimEnd(new char[] { '.', ',', '-' });
            innerString = innerString.Replace(',', ' ');
            string[] innerStringsArray = innerString.Split(' ');
            foreach (var word in innerStringsArray)
            {
                if (!WordCounterDictionary.ContainsKey(word))
                {
                    WordCounterDictionary.Add(word, 1);
                }
                else
                {
                    int value = WordCounterDictionary[word];
                    WordCounterDictionary[word] = ++value;
                }
            }

            int count = 0;
            foreach (var unicWord in WordCounterDictionary)
            {
                Console.WriteLine($"{++count}.\t {unicWord.Key} \t {unicWord.Value}");
            }
        }


    }
}
