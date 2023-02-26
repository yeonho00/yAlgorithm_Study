using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1813
    {
        static void ain()
        {
            //몇번 입력받을지 정수 입력
            int[] cnt = new int[51];
            int[] talk;
            int N = int.Parse(Console.ReadLine());
            talk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
                cnt[talk[i]]++;
            for (int i = N; i >= 0; i--)
            {
                if(cnt[i] == i)
                {
                    Console.WriteLine(i.ToString());
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
