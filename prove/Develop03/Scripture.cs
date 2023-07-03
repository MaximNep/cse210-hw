using System;
using System.Collections.Generic;

namespace ScriptureMemoryApp
{
    class Scripture
    {
        private string reference;
        private List<Verse> verses;
        private List<Word> words;

        public Scripture(string reference)
        {
            this.reference = reference;
            verses = new List<Verse>();
            words = new List<Word>();
        }

        public void AddVerse(Verse verse)
        {
            verses.Add(verse);
            foreach (string word in verse.Text.Split(' '))
            {
                words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine($"Reference: {reference}");
            foreach (Verse verse in verses)
            {
                Console.WriteLine($"{verse.Reference} : {verse.Text}");
            }
            Console.WriteLine();
        }

        public bool HideRandomWord()
        {
            Word word = GetRandomVisibleWord();
            if (word != null)
            {
                word.Hide();
                return true;
            }
            return false;
        }

        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (word.IsVisible)
                {
                    return false;
                }
            }
            return true;
        }

        private Word GetRandomVisibleWord()
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in words)
            {
                if (word.IsVisible)
                {
                    visibleWords.Add(word);
                }
            }

            if (visibleWords.Count == 0)
            {
                return null;
            }

            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            return visibleWords[index];
        }
    }
}
