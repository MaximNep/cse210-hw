using System;

namespace JournalApp
{
    // Entry class represents a journal entry containing the response, prompt, and date
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }
    }
}
