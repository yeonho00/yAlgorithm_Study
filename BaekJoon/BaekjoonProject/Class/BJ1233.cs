using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1233
    {
        static void Main()
        {
            Dictionary<int, int> diceSumCnt = new Dictionary<int, int>();
            List<int> sumList = new List<int>();
            int[] inputNumList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] dice = new int[3];
            int curIdx = 0;

            for(dice[0] = 1; dice[0] <= inputNumList[0]; dice[0]++)
            {
                for(dice[1] = 1; dice[1] <= inputNumList[1]; dice[1]++)
                {
                    for(dice[2] = 1; dice[2] <= inputNumList[2]; dice[2]++)
                    {
                        int sum = dice[0] + dice[1] + dice[2];
                        if (diceSumCnt.ContainsKey(sum))
                            diceSumCnt[sum]++;
                        else
                        {
                            sumList.Add(sum);
                            diceSumCnt.Add(sum, 1);
                        }
                    }
                }
            }            
            sumList.Sort();
            for(int i = 1, length = sumList.Count; i < length; i++)
            {
                curIdx = diceSumCnt[sumList[curIdx]] < diceSumCnt[sumList[i]] ? i : curIdx;
            }

            Console.WriteLine($"{sumList[curIdx]}");
        }
    }
}
