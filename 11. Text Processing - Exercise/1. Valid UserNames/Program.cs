using System;
using System.Linq;

namespace Strings_and_Text_Processing_UPR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] validUserName = Console.ReadLine().Split(", ", StringSplitOptions.None).ToArray();

            foreach (var item in validUserName)
            {
                if (ValidateUserName(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static bool ValidateUserName(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char currentCh = username[i];

                if (!(char.IsLetterOrDigit(currentCh) || currentCh == '-' || currentCh == '_'))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}
