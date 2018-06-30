using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMDPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string source = Console.ReadLine();
                Console.WriteLine(String.Format("Here is your palindrome length: {0}", LongestPalindrome(source).ToString()));
            }            
        }


        static int LongestPalindrome(string source)
        {
            char[] characters = source.ToArray();
            List<char> processedCharacters = new List<char>();
            bool hasOddCharacter = false;           
            int palindromeCount = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                char currentChar = characters[i];
                int characterCount;
                if (processedCharacters.Contains(currentChar))
                    continue;

                characterCount = characters.Count(x => x == currentChar);
                if (characterCount > 1)
                    if (characterCount % 2 == 0)
                    {
                        palindromeCount += characterCount;
                    }
                    else if (!hasOddCharacter)
                    {
                        palindromeCount += characterCount;
                        hasOddCharacter = true;
                    }
                    else
                    {
                        palindromeCount += characterCount - 1;
                    }
                else if (!hasOddCharacter)
                {
                    palindromeCount += 1;
                    hasOddCharacter = true;
                }

                processedCharacters.Add(currentChar);
            }

            return palindromeCount;
        }    
    }
}
