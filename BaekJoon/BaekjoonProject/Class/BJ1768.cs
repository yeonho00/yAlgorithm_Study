using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1768
    {
        static void Main()
        {
            const int N = 0;
            const int M = 1;
            Dictionary<string, bool> nDic = new Dictionary<string, bool>();
            List<string> mList = new List<string>();
            int[] length = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            nDic = InputNMethod(length[N]);
            mList = InputMMethod(length[M]);
            ChkNM(nDic, mList);
        }
        static Dictionary<string, bool> InputNMethod(int N)
        {
            Dictionary<string, bool> nDic = new Dictionary<string, bool>();
            for (int i = 0; i < N; i++)
            {
                string inputBuf = Console.ReadLine();
                if (!nDic.ContainsKey(inputBuf))
                {
                    nDic.Add(inputBuf, true);
                }
            }
            return nDic;
        }
        static List<string> InputMMethod(int M)
        {
            List<string> mList = new List<string>();
            for (int i = 0; i < M; i++)
            {
                string inputBuf = Console.ReadLine();
                if (!mList.Contains(inputBuf))
                {
                    mList.Add(inputBuf);
                }
            }
            return mList;
        }
        static void ChkNM(Dictionary<string, bool> nDic, List<string> mList)
        {
            int length = mList.Count;
            for(int i = 0; i < length; i++)
            {
                if (nDic.ContainsKey(mList[i]))
                {
                    Console.WriteLine(mList[i]);
                }
            }
        }
    }
}
