using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject
{
    class CroLetter
    {
        public char startLetter;
        public string[] strArr;
        public CroLetter(char startLetter, string[] strArr)
        {
            this.startLetter = startLetter;
            this.strArr = strArr;
        }
        public CroLetter() { }
        public static bool chkInputStr(string inputStr)
        {
            if (inputStr.Length > 100) return false;
            foreach(char inputLetter in inputStr) {
                if (('a' <= inputLetter && inputLetter <= 'z') || inputLetter.Equals('-') || inputLetter.Equals('='))
                    continue;
                else
                    return false;
            }
            return true;
        }
        public static int cntCroLetter(string inputStr, List<CroLetter> croLetterList)
        {
            int cnt = inputStr.Length;
            int curInputLetterIdx = 0;
            int inputStrLength = inputStr.Length;
            for (; curInputLetterIdx < inputStrLength; curInputLetterIdx++)
            {
                int curCroLetterIdx = 0;
                int croLetterListLength = croLetterList.Count;
                for (; curCroLetterIdx < croLetterListLength; curCroLetterIdx++)
                {
                    if(!inputStr[curInputLetterIdx].Equals(croLetterList[curCroLetterIdx].startLetter))
                    {
                        continue;
                    }
                    string subString = inputStr.Substring(curInputLetterIdx);
                    int curStrArrIdx = 0;
                    int strArrLength = croLetterList[curCroLetterIdx].strArr.Length;
                    for (; curStrArrIdx < strArrLength; curStrArrIdx++)
                    {
                        if (subString.StartsWith(croLetterList[curCroLetterIdx].strArr[curStrArrIdx]))
                        {
                            curInputLetterIdx += croLetterList[curCroLetterIdx].strArr[curStrArrIdx].Length - 1;
                            cnt -= croLetterList[curCroLetterIdx].strArr[curStrArrIdx].Length - 1;
                            break;
                        }
                    }
                }
            }
            return cnt;
        }
    }
    class BJ2941
    {
        static void ain()
        {
            List<CroLetter> croLetterList = new List<CroLetter>();
            char[] startStr = { 'c', 'd', 'l', 'n', 's', 'z' };
            string[][] str = new string[startStr.Length][];
            string inputStr;
            int cnt;

            str[0] = new string[2] { "c=", "c-" };
            str[1] = new string[2] { "dz=", "d-" };
            str[2] = new string[1] { "lj" };
            str[3] = new string[1] { "nj" };
            str[4] = new string[1] { "s=" };
            str[5] = new string[1] { "z=" };

            for(int i = 0; i < startStr.Length; i++)
            {
                croLetterList.Add(new CroLetter(startStr[i], str[i]));
            }

            while(true)
            {
                inputStr = Console.ReadLine();
                if (CroLetter.chkInputStr(inputStr))
                {
                    break;
                }
            }

            cnt = CroLetter.cntCroLetter(inputStr, croLetterList);

            Console.WriteLine(cnt);
        }
    }
}
