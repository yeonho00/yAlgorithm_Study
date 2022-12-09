using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon1316
{
    class Program
    {
        static int inputLength;
        static string[] words;

        static void Main(string[] args)
        {
            //입력을 받음
            inputMethod();
            //그룹단어인지 확인
            chkWords();
            int n = int.Parse(Console.ReadLine());
            int a = n;
            //for (int x = 0; x < n; x++) 
            //{ 
            //    string s = Console.ReadLine();
            //    bool[] check = new bool[26];
            //    for (int i = 0; i < s.Length; i++) 
            //    { 
            //        if (check[s[i] - 97])
            //        { 
            //            if (s[i] != s[i - 1])
            //            { 
            //                a--; 
            //                break; 
            //            } 
            //        } 
            //        else 
            //        { 
            //            check[s[i] - 97] = true; 
            //        } 
            //    } 
            //}
            //Console.Write(a);
        }

        static void inputMethod()
        {
            //정수 만큼 단어 입력
            setInputLength();
            setWords();

        }
        static void setInputLength()
        {
            while(true)
            {
                //몇 번 입력받을 지 정수 입력
                int num = int.Parse(Console.ReadLine());
                //정수는 100이하로 입력
                if (num <= 0 || 100 < num)
                {
                    Console.WriteLine(num.ToString());
                    Console.WriteLine("1이상 100 이하로 입력해야 합니다.");
                    Console.WriteLine("입력오류.");
                    continue;
                }
                else
                {
                    inputLength = num;
                    break;
                }
            }
        }
        static void setWords()
        {
            words = new string[inputLength];
            for (int i = 0; i < inputLength; i++)
            {
                while(true)
                {
                    string str = Console.ReadLine();
                    if(chkInputWord(str))
                    {
                        words[i] = str;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        continue;
                    }
                }
            }
        }
        static bool chkInputWord(string str)
        {
            if (str.Length <= 0 || 100 < str.Length) { return false; }
            foreach(char letter in str)
            {
                if (letter < 'a' || 'z' < letter) { return false; }
            }
            return true;
        }
        static void chkWords()
        {
            int cnt = 0;

            //사용된 문자를 기억
            foreach(string word in words)
            {
                if (chkLetters(word))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
        static bool chkLetters(string word)
        {
            bool[] isUse = new bool[26];
            for(int i = 0; i < isUse.Length; i++)
                isUse[i] = false;
            int wdLength = word.Length;
            isUse[word[0] - 'a'] = true;
            for (int nowLetter = 1; nowLetter < wdLength; nowLetter++)
            {
                //앞 문자와 현재 문자가 같다면 다음으로
                //앞 문자와 현재 문자가 다르다면 사용된 문자인지 확인
                if (!word[nowLetter].Equals(word[nowLetter - 1]))
                {
                    //사용된 문자라면 그룹단어가 아님
                    if (isUse[word[nowLetter] - 'a'])
                    {
                        return false;
                    }
                    //사용되지 않았다면 반복
                    else
                    {
                        isUse[word[nowLetter] - 'a'] = true;
                    }
                }
            }
            return true;
        }
    }
}
