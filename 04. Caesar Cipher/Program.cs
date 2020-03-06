using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                char encryptedSymbol = (char)(symbol + 3);
                encryptedText.Append(encryptedSymbol);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
