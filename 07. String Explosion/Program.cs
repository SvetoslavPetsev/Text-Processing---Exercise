using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        bool bombBOOM = false;
        int boomStrenght = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char curr = input[i];

            if (!bombBOOM)
            {
                if (curr == '>')
                {
                    result.Append(curr);
                    if (!bombBOOM)
                    {
                        bombBOOM = true;
                        boomStrenght = int.Parse(input[i + 1].ToString());
                    }
                }
                if (curr != '>' && !bombBOOM)
                {
                    result.Append(curr);
                }
            }
            else
            {
                if (curr == '>')
                {
                    boomStrenght += int.Parse(input[i + 1].ToString());
                    curr = input[i];
                    result.Append(curr);
                }
                else if (boomStrenght - 1 > 0)
                {
                    boomStrenght--;
                    continue;
                }
                else
                {
                    bombBOOM = false;
                }
            }
        }
        Console.WriteLine(result);
    }
}

