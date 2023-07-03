using System;
using System.Collections.Generic;

namespace ScriptureMemoryApp
{
    class Scripture
    {
        private string reference;
        private string text;
        private List<Word> words;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
            words = new List<Word>();
            InitializeWords();
        }

        private void InitializeWords()
        {
            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine($"Reference: {reference}\nText: {GetVisibleText()}\n");
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

        private string GetVisibleText()
        {
            string visibleText = "";
            foreach (Word word in words)
            {
                visibleText += word.GetText() + " ";
            }
            return visibleText.Trim();
        }
    }
}
