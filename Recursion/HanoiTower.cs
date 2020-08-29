using System;
using System.Text;

namespace CSharpAlgorizm.Recursion
{
    class HanoiTower
    {
        static StringBuilder sb = new StringBuilder();
        static int number = 1;
        static int buildTower(int num, int from,int by, int to)
        {
            if(num == 1)
            {
                sb.Append(from + " " + to+"\n");
                return 0;
            }
            else
            {
                buildTower(num - 1, from, to, by);
                sb.Append(from + " " + to + "\n");
                buildTower(num - 1, by, from, to);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            number = Convert.ToInt16(Console.ReadLine());
            int sum = Convert.ToInt32(Math.Pow(2, number) - 1);
            sb.Append(sum + "\n");
            buildTower(number,1,2,3);
            Console.WriteLine(sb.ToString());
        }
    }
}