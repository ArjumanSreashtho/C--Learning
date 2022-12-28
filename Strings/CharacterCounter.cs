using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Strings
{
    internal class CharacterCounter
    {
        public static void Run()
        {
            Console.Write("Enter a Line: ");
            string input = Console.ReadLine();
            int[] characters = CalculateCharacters(input);
            PrintCharacters(characters);

        }
        private static int[] CalculateCharacters(string input)
        {
            int[] characters = new int[256];
            foreach(char ch in input)
            {
                characters[ch]++;
            }
            return characters;
        }

        private static void PrintCharacters(int[] characters)
        {
            for(int i = 0; i < 256; i++)
            {
                if (characters[i] > 0)
                {
                    Console.WriteLine($"{(char)i} = {characters[i]}");

                }
            }
        }
    }
}
