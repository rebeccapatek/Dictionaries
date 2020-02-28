using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();
            // wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            // wordsAndDefinitions.Add ("Cool", "The feeling when you skip school");
            // wordsAndDefinitions.Add ("Ugli", "The feeling of your face stinks at looking good");
            // wordsAndDefinitions.Add ("Fun", "The feeling of eating a great sandwich");
            // wordsAndDefinitions.Add ("Excited", "The feeling of eating a great sandwich");

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
                Console.WriteLine ($"The definition of {word.Key} is {word.Value}");
            }
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();
            excitedWord.Add ("word", "Excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to learn C#!");
            dictionaryOfWords.Add (excitedWord);
            Dictionary<string, string> awesomeWord = new Dictionary<string, string> ();
            awesomeWord.Add ("word", "Awesome");
            awesomeWord.Add ("definition", "The feeling of students when they are learning C#");
            awesomeWord.Add ("part of speech", "adjective");
            awesomeWord.Add ("example sentence", "I am awesome!");
            dictionaryOfWords.Add (awesomeWord);

            Dictionary<string, string> coolWord = new Dictionary<string, string> ();
            coolWord.Add ("word", "Cool");
            coolWord.Add ("definition", "The feeling when you skip school");
            coolWord.Add ("part of speech", "adjective");
            coolWord.Add ("example sentence", "I wanted to feel cool.");
            dictionaryOfWords.Add (coolWord);
            Dictionary<string, string> ugliWord = new Dictionary<string, string> ();
            ugliWord.Add ("word", "ugli");
            ugliWord.Add ("definition", "The feeling of your face stinks at looking good");
            ugliWord.Add ("part of speech", "adjective");
            ugliWord.Add ("example sentence", "My puppy feels ugli today");
            dictionaryOfWords.Add (ugliWord);
            Dictionary<string, string> funWord = new Dictionary<string, string> ();
            funWord.Add ("word", "fun");
            funWord.Add ("definition", "The feeling of eating a great sandwich");
            funWord.Add ("part of speech", "adjective");
            funWord.Add ("example sentence", "I am having fun");
            dictionaryOfWords.Add (funWord);
            foreach (Dictionary<string, string> word in dictionaryOfWords) {
                foreach (KeyValuePair<string, string> wordData in word) {
                    Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
                }
            }

        }
    }
}