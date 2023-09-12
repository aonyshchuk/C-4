using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_4
{
    public class PseudoGenerator
    {
        private static readonly Random random = new Random();
        private const string vowels = "aеєиіїоуюя";
        private const string consonants = "бвгґджзйклмнпрстфхцчшщь";

        public static string GenerateLoremIpsum(int numVowels, int numConsonants, int maxWordLength, int numWords)
        {
            StringBuilder loremIpsum = new StringBuilder();

            for (int i = 0; i < numWords; i++)
            {
                int wordLength = random.Next(1, maxWordLength + 1);
                StringBuilder word = new StringBuilder();

                for (int j = 0; j < wordLength; j++)
                {
                    if (j % 2 == 0 && numConsonants > 0)
                    {
                        word.Append(GetRandomCharacter(consonants));
                        numConsonants--;
                    }
                    else if (numVowels > 0)
                    {
                        word.Append(GetRandomCharacter(vowels));
                        numVowels--;
                    }
                    else
                    {
                        word.Append(GetRandomCharacter(consonants));
                    }
                }

                loremIpsum.Append(word);
                if (i < numWords - 1)
                {
                    loremIpsum.Append(" ");
                }
            }

            return loremIpsum.ToString();
        }

        private static char GetRandomCharacter(string characters)
        {
            int index = random.Next(characters.Length);
            return characters[index];
        }
    }
}
