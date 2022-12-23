using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject
{
    class BJ1297
    {
        public static void ain()
        {
            int D, H, W;
            double Ds, Hs, Ws, temp;

            string inputStr = Console.ReadLine();
            string[] numStrList = inputStr.Split(' ');
            D = int.Parse(numStrList[0]);
            H = int.Parse(numStrList[1]);
            W = int.Parse(numStrList[2]);

            Ds = D * D;
            Hs = H * H;
            Ws = W * W;

            temp = Hs + Ws;
            temp = Ds / temp;
            Hs *= temp;
            Ws *= temp;

            Console.WriteLine($"{(int)Math.Sqrt(Hs)} {(int)Math.Sqrt(Ws)}");
        }
    }
}
