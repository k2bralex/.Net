using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_04
{
    class Dictionary
    {
        private Dictionary<int, string> _sentenceResult = new Dictionary<int, string>();
        public void Run()
        {
            Sentence newSentence = new Sentence();

        }
    }
    class Sentence
    {
        private List<string> SentenceList { get; set; } = new List<string>();
        private int WordInSentence { get; set; } = 0;

        public Sentence()
        {
            string newString = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане " +
                "хранится В доме, Который построил Джек.А это веселая птица-синица, " +
                "Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            SentenceList = newString.Split(' ').ToList();
        }

        public void Calculator()
        {
            Console.WriteLine($"Total word in sentence: {SentenceList.Count}");
            foreach (var word in SentenceList)
            {
                
            }
        }
    }
}
