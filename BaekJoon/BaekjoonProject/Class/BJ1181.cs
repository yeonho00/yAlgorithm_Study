using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1181
    {
        static void ain()
        {
            Dictionary<int, List<string>> strDic = new Dictionary<int, List<string>>();
            int inputLength = int.Parse(Console.ReadLine());

            for(int i = 0; i < inputLength; i++)
            {
                string strBuf = Console.ReadLine();
                switch(ChkList(strDic, strBuf))
                {
                    case -1: strDic.Add(strBuf.Length, new List<string>()); 
                             strDic[strBuf.Length].Add(strBuf);
                             break;
                    case 0:  strDic[strBuf.Length].Add(strBuf); 
                             break;
                    default: break;
                }
            }

            List<int> keyList = new List<int>(strDic.Keys);
            keyList.Sort();
            foreach(int i in keyList)
            {
                strDic[i].Sort();
                foreach(string s in strDic[i])
                {
                    Console.WriteLine(s);
                }
            }
        }
        static int ChkList(Dictionary<int, List<string>> strDic, string strBuf)
        {
            //-1: key 없음
            //0: value 없음
            //1: 이미 있음
            int strBufLength = strBuf.Length;
            if (strDic.ContainsKey(strBufLength))
            {
                List<string> strListBuf = strDic[strBufLength];
                if (strListBuf.Contains(strBuf))
                    return 1;
                else
                    return 0;
            }
            else    return -1;
        }
    }
}
