using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1259
    {
        static void ain()
        {
            //string[] inputStr = null;
            List<string> inputStr = new List<string>();
            while (true)
            {
                string inputStrBuf = Console.ReadLine();
                if (inputStrBuf.Equals("0"))
                    break;
                inputStr.Add(inputStrBuf);
            }
            foreach(string s in inputStr)
                Console.WriteLine(ChkPalindrome(s) ? "yes" : "no");
        }
        static bool ChkPalindrome(string str)
        {
            for(int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (!str[i].Equals(str[j])) return false;
            }
            return true;
        }
    }
}
