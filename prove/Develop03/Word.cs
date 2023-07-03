using System;

namespace ScriptureMemoryApp
{
    class Word
    {
        private string text;
        private bool isVisible;

        public Word(string text)
        {
            this.text = text;
            isVisible = true;
        }

        public void Hide()
        {
            isVisible = false;
        }

        public string GetText()
        {
            return (isVisible) ? text : "_____";
        }

        public bool IsVisible
        {
            get { return isVisible; }
        }
    }
}
