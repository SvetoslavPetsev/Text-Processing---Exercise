using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];

            string maxLenghtWord = word1;
            string minLenghtWord = word2;

            if (maxLenghtWord.Length < minLenghtWord.Length)
            {
                maxLenghtWord = word2;
                minLenghtWord = word1; 
            }
            int sum = 0;
            for (int i = 0; i < maxLenghtWord.Length; i++)
            {
                if (i < minLenghtWord.Length)
                {
                    sum += maxLenghtWord[i] * minLenghtWord[i];
                }
                else
                {
                    sum += maxLenghtWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
