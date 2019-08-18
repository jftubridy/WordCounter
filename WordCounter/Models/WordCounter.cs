using System;
using WordCounter.Models;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string InputSentence { get; set; }
        public string InputWord { get; set; }

        public static char[] signs = { ' ', ',', '.', ';', ':', '!', '?', '/', '@', '#', '$', '%', '^', '^', '&', '*', '(', ')', '-', '_', '=', '+', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public RepeatCounter(string inputSentence, string inputWord)
        {
            InputSentence = inputSentence.ToLower();
            InputWord = inputWord.ToLower();
        }


        public int WordNumber()
        {
            int totalWords = 0;
            string[] splitSentence = InputSentence.Split(signs);
            for (int i = 0; i < splitSentence.Length; i++)
                if (splitSentence[i] == InputWord)
                {
                    totalWords++;
                }
            return totalWords;
        }


    }
}
