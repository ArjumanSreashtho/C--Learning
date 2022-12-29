using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Structure
{
    struct Data
    {
        public int count;
        public int pos;
    }
    internal class CharacterCounterMod
    {
        public static void Run()
        {
            Console.Write("Enter a Line: ");
            string input = Console.ReadLine();
            Data[] characters = CalculateCharacters(input);
            PrintCharacters(characters, input);

        }
        private static Data[] CalculateCharacters(string input)
        {
            int length = input.Length;
            Data[] characters = new Data[256];
            for (int i = 0; i < length; i++)
            {
                if(characters[input[i]].count == 0)
                {
                    characters[input[i]].pos = i;
                }
                characters[input[i]].count++;
            }
            return characters;
        }

        private static void PrintCharacters(Data[] characters, string input)
        {
            
            int len = characters.Length;
            SortData(characters, len);
            for(int i = 0; i < len; i++)
            {
                if (characters[i].count > 0)
                Console.WriteLine(input[characters[i].pos] + " " + characters[i].count);
            }
        }

        private static void SortData(Data[] characters, int len)
        {
            for(int i = 0; i < len; i++)
            {
                for(int j = i+1; j < len; j++) 
                {
                    if (characters[i].pos > characters[j].pos)
                    {
                        SwapData(ref characters[i], ref characters[j]);
                    }
                }
            }
        }

        private static void SwapData(ref Data data1, ref Data data2)
        {
            Data temp = data1;
            data1 = data2;
            data2 = temp;
        }
        
    }
}
