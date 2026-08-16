using System;

namespace task4;

class Vocabulary
{
    string[] englishWords;
    string[] russianWords;

    string[] UkrainianWords;

    public Vocabulary()
    {
        englishWords = new string[0];
        russianWords = new string[0];
        UkrainianWords = new string[0];
    }

    public void AddWord(string english, string russian, string ukrainian)
    {
        Array.Resize(ref englishWords, englishWords.Length + 1);
        Array.Resize(ref russianWords, russianWords.Length + 1);
        Array.Resize(ref UkrainianWords, UkrainianWords.Length + 1);

        englishWords[englishWords.Length - 1] = english;
        russianWords[russianWords.Length - 1] = russian;
        UkrainianWords[UkrainianWords.Length - 1] = ukrainian;
    }

    public void GetEnglishWords(string ukrainian)
    {
        System.Console.WriteLine("Searching for English translation of the Ukrainian word: " + ukrainian);
        for (int i = 0; i < UkrainianWords.Length; i++)
        {
            if (string.Equals(UkrainianWords[i], ukrainian, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"English: {englishWords[i]}");
                return;
            }
        }

        Console.WriteLine("Word not found in the vocabulary.");
    }

    public void GetRussianWords(string ukrainian)
    {
        System.Console.WriteLine("Searching for Russian translation of the Ukrainian word: " + ukrainian);
        for (int i = 0; i < UkrainianWords.Length; i++)
        {
            if (string.Equals(UkrainianWords[i], ukrainian, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Russian: {russianWords[i]}");
                return;
            }
        }

        Console.WriteLine("Word not found in the vocabulary.");
    }


    public void ShowVocabulary()
    {
        Console.WriteLine("Vocabulary:");
        for (int i = 0; i < englishWords.Length; i++)
        {
            Console.WriteLine($"{englishWords[i]} - {russianWords[i]} - {UkrainianWords[i]}");
        }
    }

}