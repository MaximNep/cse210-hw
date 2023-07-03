using System;

namespace ScriptureMemoryApp
{
    class Reference
    {
        private string book;
        private int chapter;
        private int verseStart;
        private int verseEnd;

        public Reference(string reference)
        {
            string[] parts = reference.Split(':');
            book = parts[0];
            chapter = Int32.Parse(parts[1].Split('-')[0]);
            string[] verseParts = parts[1].Split('-')[1].Split(',');
            verseStart = Int32.Parse(verseParts[0]);
            verseEnd = (verseParts.Length > 1) ? Int32.Parse(verseParts[1]) : verseStart;
        }

        public string GetReference()
        {
            if (verseStart == verseEnd)
            {
                return $"{book} {chapter}:{verseStart}";
            }
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}
