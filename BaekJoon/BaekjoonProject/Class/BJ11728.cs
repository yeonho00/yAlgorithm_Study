using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class BJ11728
    {
        static void ain()
        {

            SortedSet<int> sortedSet = new SortedSet<int>();
            List<int[]> list = new List<int[]>();
            int[] inputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            list.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            list.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            int listLength;
            listLength = list[0].Length;
            for (int i = 0; i < listLength; i++)
                sortedSet.Add(list[0][i]);
            listLength = list[1].Length;
            for (int i = 0; i < listLength; i++)
                sortedSet.Add(list[1][i]);
            
            foreach (int item in sortedSet)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
