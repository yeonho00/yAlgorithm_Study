using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ2751
    {
        static void ain()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int N = int.Parse(sr.ReadLine());
            int[] inputNumList = new int[N];

            for (int i = 0; i < N; i++)
            {
                inputNumList[i] = int.Parse(sr.ReadLine());
            }
            Array.Sort(inputNumList);

            foreach (var item in inputNumList)
            {
                sb.AppendLine(item.ToString());
            }
            sw.Write(sb);
            
            sr.Close();
            sw.Close();
        }
    }
}
