using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your numbers: ");
            string[] numeric = Console.ReadLine().Split();
            int[] numbers = new int[numeric.Length];

            for (int i = 0; i < numeric.Length; i++)
                numbers[i] = int.Parse(numeric[i]);

            Console.WriteLine("Now please enter your target number: ");
            int target_number = int.Parse(Console.ReadLine());

            int index1 = 0, index2 = 0;
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                for (int y = x + 1; y < numbers.Length; y++)
                {
                    if (numbers[x] + numbers[y] == target_number)
                    {
                        index1 = x;
                        index2 = y;
                        goto LoopEnd;
                    }

                }

            }

            LoopEnd:
            Console.WriteLine("Your target number is resulted by" +
                            " sum of the two following indexes: " + index1 + " and " + index2);

            Console.ReadKey();
        }
    }
}
