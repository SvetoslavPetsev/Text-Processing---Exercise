using System;
using System.Text;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();
            string multiplayer = Console.ReadLine();
            int onMind = 0;

            StringBuilder sum = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                int multypl = int.Parse(numberAsString[i].ToString()) * int.Parse(multiplayer) + onMind;
                sum.Append(multypl % 10);
                onMind = multypl / 10;
            }
            if (onMind != 0)
            {
                sum.Append(onMind);
            }

            string revurse = string.Join("", sum.ToString().Reverse()).TrimStart('0');
            if (revurse == string.Empty)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(revurse);
            }
        }
    }
}
