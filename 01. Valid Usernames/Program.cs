using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string[] userNames = Console.ReadLine().Split(", ");

            for (int i = 0; i < userNames.Length; i++)
            {
                bool validLenght = true;
                bool validSymol = true;
                string currWord = userNames[i];
                if (currWord.Length < 3 || currWord.Length > 16)
                {
                    validLenght = false;
                }
                foreach (var item in currWord)
                {
                    if (!char.IsLetterOrDigit(item) && item != '-' && item != '_')
                    {
                        validSymol = false;
                    }
                }
                if (validLenght && validSymol)
                {
                    Console.WriteLine(currWord);
                }
            }
        }
    }
}
