using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ10129
    {
        static void ain()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder[] sb = null;
            const int H = 0;
            const int W = 1;

            sw.AutoFlush = true;

            int T = int.Parse(sr.ReadLine());
            int[][] HW = new int[T][];
            sb = new StringBuilder[T+1];
            sb[T] = new StringBuilder();

            for (int t = 0; t < T; t++)
            {
                sb[t] = new StringBuilder();
                HW[t] = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int h = 0; h < HW[t][H]; h++)
                {
                    sb[t].Append(sr.ReadLine());
                    for (int w = HW[t][W]-1; w >= 0; w--)
                        sb[T].Append(sb[t][w]);
                    sb[t].Clear();
                    sb[T].Append('\n');
                }
            }
            sw.Write(sb[T]);
        }
    }
}
