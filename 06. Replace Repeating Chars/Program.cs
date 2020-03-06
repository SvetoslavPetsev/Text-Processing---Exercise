using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            char provius = '\0';
            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];
                if (currSymbol != provius)
                {
                    result.Append(currSymbol);
                    provius = currSymbol;
                }
            }
            Console.WriteLine(result);
        }
    }
}
