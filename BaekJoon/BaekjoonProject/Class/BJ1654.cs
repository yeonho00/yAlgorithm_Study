using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1654
    {
        static void Main()
        {
            int[] KN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int K = KN[0];
            int N = KN[1];
            int maxLen = 0;
            int minLen = int.MaxValue;
            var list = new List<int>();
            double multiValue = (double)N / K;
            
            for (int i = 0; i < K; i++)
            {
                int intBuf = int.Parse(Console.ReadLine());
                list.Add(intBuf);
                if(maxLen < intBuf) { maxLen = intBuf; continue; }
                if(minLen > intBuf) { minLen = intBuf; continue; }
            }

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
