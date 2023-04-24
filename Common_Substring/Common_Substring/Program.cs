using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCommonLetters = 0;
            int optimal = 0;

            Console.WriteLine("Please enter your words: ");
            string[] words = Console.ReadLine().Split();

            optimal = Math.Min(words[0].Length, words[1].Length);

            for (int j = 0; j < optimal; j++)
            {
                if (words[0][j] == words[1][j])
                    maxCommonLetters += 1;
                else break;
            }

            if (maxCommonLetters != 0)
            {
                for (int i = 2; i < words.Length; i++)
                    maxCommonLetters = Math.Min(maxCommonLetters, words[i].Length);

                for (int i = 1; i < words.Length - 1; i++)
                {
                    for (int j = maxCommonLetters - 1; j >= 0; j--)
                    {
                        if (words[i][j] != words[i + 1][j])
                            maxCommonLetters -= 1;
                    }
                }

                for (int j = 0; j < maxCommonLetters; j++)
                    Console.Write(words[0][j]);
            }
            
            else
            Console.WriteLine("these words don't have any common beginning letter!");

            Console.ReadKey();
        }

    }
}







