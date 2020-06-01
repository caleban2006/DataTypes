using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'".ToLower();
            
            Console.WriteLine("Enter the term you would like to search for in Alice in Wonderland?");

            string searchTerm = Console.ReadLine().ToLower();
            bool containsSearchTerm = firstSentence.Contains(searchTerm);
            Console.WriteLine(containsSearchTerm);

            int indexOfSearchTerm = firstSentence.IndexOf(searchTerm);
            int lengthOfSearchTerm = searchTerm.Length;
            Console.WriteLine(indexOfSearchTerm);
            Console.WriteLine(lengthOfSearchTerm);

            string nextSentence = firstSentence.Remove(indexOfSearchTerm, lengthOfSearchTerm);
            Console.WriteLine(nextSentence);



        }
    }
}
