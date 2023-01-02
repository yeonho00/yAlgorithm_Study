using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1764
    {
        static void Main()
        {
            const int N = 0;
            const int M = 1;
            Dictionary<string, bool> nDic = new Dictionary<string, bool>();
            List<string> mList = new List<string>();
            int[] length = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            nDic = InputNMethod(length[N]);
            ChkNM(nDic, length[M]);
        }
        static Dictionary<string, bool> InputNMethod(int N)
        {
            bool b;
            var nDic = new Dictionary<string, bool>();
            for (int i = 0; i < N; i++)
            {
                string inputBuf = Console.ReadLine();
                if (!nDic.TryGetValue(inputBuf, out b))
                {
                    nDic.Add(inputBuf, true);
                }
            }
            return nDic;
        }
        static void ChkNM(Dictionary<string, bool> nDic, int M)
        {
            bool b;
            var mDic = new Dictionary<string, bool>();
            for(int i = 0; i < M; i++)
            {
                string inputBuf = Console.ReadLine();
                if (nDic.TryGetValue(inputBuf, out b) && !mDic.TryGetValue(inputBuf, out b))
                {
                    mDic.Add(inputBuf, true);
                }
            }
            var sList = new List<string>(mDic.Keys);
            sList.Sort();
            Console.WriteLine(sList.Count.ToString());
            foreach(string str in sList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
