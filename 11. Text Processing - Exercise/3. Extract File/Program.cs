using System;
using System.Linq;
using System.Text;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { '.','\\'};
            string[] input = Console.ReadLine().Split(delimiterChars, StringSplitOptions.None).ToArray();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            fileName = input.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
