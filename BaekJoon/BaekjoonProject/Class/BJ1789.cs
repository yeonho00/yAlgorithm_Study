using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1789
    {
        static void ain()
        {
            long S = long.Parse(Console.ReadLine());
            long sum = 0;
            long i = 1;
            while(sum+i <= S)
            {
                sum += i++;
            }

            Console.WriteLine(--i);
        }
    }
}
