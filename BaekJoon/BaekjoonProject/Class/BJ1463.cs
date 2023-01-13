using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ1463
    {
        static void Main()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int N = int.Parse(Console.ReadLine());
            int cnt = CntCalc(dic, N);

            Console.WriteLine(cnt);
        }

        static int CntCalc(Dictionary<int, int> dic, int curNum)
        {
            int one, two, three;
            
            if(curNum % 3 == 0) three = curNum / 3;
            if(curNum % 2 == 0) two = curNum / 2;
            one = curNum - 1;

            if(dic.Contains(three))
        }
    }
}
