using System;
using WordCounter.Models;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Please enter a sentence");
        string inputSentence = Console.ReadLine();
        Console.WriteLine("Please enter a word to be counted");
        string inputWord = Console.ReadLine();

        RepeatCounter newCounter = new RepeatCounter(inputSentence, inputWord);
        int totalWords = newCounter.WordNumber();
        Console.WriteLine($"Your word occurs {totalWords} times in your sentence");
    }
}
