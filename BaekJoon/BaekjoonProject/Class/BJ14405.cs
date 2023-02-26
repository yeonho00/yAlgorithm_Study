using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ14405
    {
        static string[] strList = { "pi", "ka", "chu" };
        static void ain()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            sb.Append(sr.ReadLine());

            for (int i = 0; i < strList.Length; i++)
                sb.Replace(strList[i], "*");

            for (int i = 0; i < sb.Length; i++)
            {
                if(!sb[i].Equals('*'))
                {
                    sw.WriteLine("NO");
                    return;
                }
            }

            sw.WriteLine("YES");
            return;
        }
    }
}
