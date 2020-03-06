using System;
using System.Text;

namespace _03._Extract_File
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder fileExtension = new StringBuilder();
            StringBuilder fileName = new StringBuilder();

            int indexStartExtension = input.LastIndexOf('.');
            int indexStartName = input.LastIndexOf((char)92);
            for (int i = indexStartName + 1; i < input.Length; i++)
            {
                if (i < indexStartExtension)
                {
                    fileName.Append(input[i]);
                }
                else if (i == indexStartExtension)
                {
                    continue;
                }
                else
                {
                    fileExtension.Append(input[i]);
                }
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
