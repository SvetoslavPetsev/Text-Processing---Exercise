using System;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static bool IsUppercase(char a)
        {
            return a >= 65 && a <= 90;
        }
        static int GetUppercaseLetterInAlphabet(char b)
        {
            return b - 64;
        }
        static int GetLowercaseLetterInAlphabet(char b)
        {
            return b - 96;
        }
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            foreach (string item in input)
            {
                char firsLetter = item[0];
                char lastLetter = item[item.Length - 1];
                StringBuilder currNumberAsString = new StringBuilder();
                for (int i = 1; i < item.Length - 1; i++)
                {
                    currNumberAsString.Append(item[i]);
                }
                decimal number = decimal.Parse(currNumberAsString.ToString());
                if (IsUppercase(firsLetter))
                {
                    number /= GetUppercaseLetterInAlphabet(firsLetter);
                }
                else
                {
                    number *= GetLowercaseLetterInAlphabet(firsLetter);
                }
                if (IsUppercase(lastLetter))
                {
                    number -= GetUppercaseLetterInAlphabet(lastLetter);
                }
                else
                {
                    number += GetLowercaseLetterInAlphabet(lastLetter);
                }
                sum += number;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
