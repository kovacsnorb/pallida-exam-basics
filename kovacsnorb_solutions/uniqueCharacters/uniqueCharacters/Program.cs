using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myUnique = GetUniqueCharacters("anagram");

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
