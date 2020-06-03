using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Which word would you like to search?");
            string search = Console.ReadLine();
            string newAlice = alice.ToLower(); 

            if (newAlice.Contains(search))
            {
                Console.WriteLine($"The word {search} was located.");
            }
            else
            {
                Console.WriteLine($"The word {search} was NOT located.");
            }
            int index = newAlice.IndexOf(search);
            int length = search.Length;

            Console.WriteLine($"The word {search} was located at index {index} and has a length of {length}");





        }
    }
}
