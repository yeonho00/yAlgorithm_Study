using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1296
    {
        const int L = 0;
        const int O = 1;
        const int V = 2;
        const int E = 3;
        static void Main()
        {
            int loopNum = 0;
            string name = null;
            string[] teamName = null;
            int[] cntLOVE = null;
            int[] cntLOVEBuf = null;
            int[] points = null;
            int curIdx = 0;

            //InputMethod(out loopNum, out name, out teamName);
            {
                name = Console.ReadLine();
                loopNum = int.Parse(Console.ReadLine());
                teamName = new string[loopNum];
                for (int i = 0; i < loopNum; i++)
                {
                    teamName[i] = Console.ReadLine();
                }
            }
            points = new int[loopNum];

            Array.Sort(teamName);
            cntLOVE = CntLOVEMethod(name);
            for (int i = 0; i < loopNum; i++)
            {
                cntLOVEBuf = CntLOVEMethod(teamName[i]);
                points[i] = CalcMethod(cntLOVE, cntLOVEBuf);
            }
            for (int i = 1; i < loopNum; i++)
            {
                curIdx = points[i] > points[curIdx] ? i : curIdx;
            }

            Console.WriteLine($"{teamName[curIdx]}");
        }
        static int[] CntLOVEMethod(string str)
        {
            int[] cntLOVE = new int[4];
            foreach (char c in str)
            {
                switch (c)
                {
                    case 'L': cntLOVE[L]++; break;
                    case 'O': cntLOVE[O]++; break;
                    case 'V': cntLOVE[V]++; break;
                    case 'E': cntLOVE[E]++; break;
                    default: break;
                }
            }
            return cntLOVE;
        }
        static int CalcMethod(int[] cntLOVE, int[] cntLOVEBuf)
        {
            for (int i = 0; i < 4; i++)
            {
                cntLOVEBuf[i] += cntLOVE[i];
            }
            return ((cntLOVEBuf[L] + cntLOVEBuf[O]) *
                    (cntLOVEBuf[L] + cntLOVEBuf[V]) *
                    (cntLOVEBuf[L] + cntLOVEBuf[E]) *
                    (cntLOVEBuf[O] + cntLOVEBuf[V]) *
                    (cntLOVEBuf[O] + cntLOVEBuf[E]) *
                    (cntLOVEBuf[V] + cntLOVEBuf[E])) % 100;
        }
        static void InputMethod(out int loopNum, out string name, out string[] teamName)
        {
            while (true)
            {
                name = Console.ReadLine();
                if (1 <= name.Length && name.Length <= 20)
                    break;
            }
            while (true)
            {
                loopNum = int.Parse(Console.ReadLine());
                if (1 <= loopNum && loopNum <= 50)
                    break;
            }
            teamName = new string[loopNum];
            for (int i = 0; i < loopNum; i++)
            {
                while (true)
                {
                    teamName[i] = Console.ReadLine();
                    if (1 <= teamName[i].Length && teamName.Length <= 20)
                        break;
                }
            }
        }
    }
}
