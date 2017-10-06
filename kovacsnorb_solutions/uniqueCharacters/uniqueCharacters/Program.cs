using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            var myUnique = GetUniqueCharacters("rekettyes");

            for (int i = 0; i < myUnique.Count - 1; i++)
            {
                Console.Write("\"{0}\", ", myUnique[i]);
            }
            Console.WriteLine("\"{0}\"", myUnique[myUnique.Count - 1]);

            Console.ReadLine();
        }

        public static List<char> GetUniqueCharacters(string inputString)
        {
            char[] allLetters = inputString.ToCharArray();
            var uniqueChars = new List<char>();
            var duplicateChars = new List<char>();

            foreach (Char character in allLetters)
            {
                if(!uniqueChars.Contains(character) && !duplicateChars.Contains(character))
                {
                    uniqueChars.Add(character);
                }
                else
                {
                    uniqueChars.Remove(character);
                    duplicateChars.Add(character);
                }
            }
       
            return uniqueChars;
        }
    }
}
