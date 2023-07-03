using System;

namespace ScriptureMemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("John 6:26, Matthew 8:12");
            scripture.AddVerse(new Verse("John 6:26", "Jesus answered them and said, Verily, verily, I say unto you, Ye seek me, not because ye saw the miracles, but because ye did eat of the loaves, and were filled."));
            scripture.AddVerse(new Verse("Matthew 8:12", "But the children of the kingdom shall be cast out into outer darkness: there shall be weeping and gnashing of teeth."));

            while (true)
            {
                Console.Clear();
                scripture.Display();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words hidden. Press any key to exit.");
                    Console.ReadKey();
                   
