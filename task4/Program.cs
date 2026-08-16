using System;

namespace task4;

 class Program
{
    static void Main()
    {
        Vocabulary vocabulary = new Vocabulary();

        vocabulary.AddWord("Hello", "Привет", "Привіт");
        vocabulary.AddWord("Goodbye", "До свидания", "До побачення");
        vocabulary.AddWord("Thank you", "Спасибо", "Дякую");
        vocabulary.AddWord("Please", "Пожалуйста", "Будь ласка");
        vocabulary.AddWord("Yes", "Да", "Так");
        vocabulary.AddWord("No", "Нет", "Ні");
        vocabulary.ShowVocabulary();
        vocabulary.GetEnglishWords("привіт");
        vocabulary.GetRussianWords("привіт");
    }
}
