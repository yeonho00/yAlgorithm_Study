using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1018
    {
        static void ain()
        {
            string[] board = null;
            int[] numNM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = numNM[0];
            int M = numNM[1];
            int minCnt = int.MaxValue;
            int maxX = M - 8;
            int maxY = N - 8;

            board = new string[N];
            for(int n = 0; n < N; n++)
            {
                board[n] = Console.ReadLine();
            }

            for(int y = 0; y <= maxX; y++)
            {
                for(int x = 0; x <= maxY; x++)
                {
                    int cntBuf = CntBWMethod(board, x, y);
                    minCnt = minCnt > cntBuf ? cntBuf : minCnt;
                }
            }

            Console.WriteLine(minCnt);
        }
        static int CntBWMethod(string[] board, int x, int y)
        {
            string buf = "BW";
            const int BStartBoard = 0;
            const int WStartBoard = 1;
            int[] modifyCnt = new int[2];

            for (int curY = x, lastYIdx = x + 8; curY < lastYIdx; curY++)
            {
                for (int curX = y, lastXIdx = y + 8; curX < lastXIdx; curX++)
                {
                    if(!board[curY][curX].Equals(buf[(curX + curY) % 2]))
                    {
                        modifyCnt[BStartBoard]++;
                    }
                    else
                    {
                        modifyCnt[WStartBoard]++;
                    }
                }
            }
            return modifyCnt[BStartBoard] <= modifyCnt[WStartBoard] ? modifyCnt[BStartBoard] : modifyCnt[WStartBoard];
        }
    }
}
