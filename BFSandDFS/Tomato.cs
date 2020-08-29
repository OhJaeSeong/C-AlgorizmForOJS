using System;
using System.Collections.Generic;

namespace CSharpAlgorizm
{
    class Tomato
    {
        static int garo = 0;
        static int sero = 0;
        static Boolean Allripen(int[][] t)
        {
            for (int s = 0; s < sero; s++)
            {
                for(int g = 0; g < garo; g++)
                {
                    if(t[s][g] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split();
            garo = Convert.ToInt32(st[0]);
            sero = Convert.ToInt32(st[1]);
            int[][] tomatos = new int[sero][];
            string[] str = new string[garo];
            Queue<int> xq = new Queue<int>();
            Queue<int> yq = new Queue<int>();
            int loop = 0; int count = 0;
            int x = 0, y = 0; int viCount = 0;
            for (int ss = 0; ss < sero; ss++)
            {
                tomatos[ss] = new int[garo];
                str = Console.ReadLine().Split();
                for (int gg = 0; gg < garo; gg++)
                {
                    tomatos[ss][gg] = Convert.ToInt16(str[gg]);
                    if(tomatos[ss][gg] == 1)
                    {
                        xq.Enqueue(gg);
                        yq.Enqueue(ss);
                        count++;
                    }
                }
            }
            if (Allripen(tomatos))
            {
                Console.WriteLine(0);
            }
            else
            {
                while (xq.Count != 0)
                {
                    viCount = count;
                    count = 0;
                    for (int p = 0; p < viCount; p++)
                    {
                        x = xq.Dequeue();
                        y = yq.Dequeue();
                        if (x > 0 && tomatos[y][x - 1] == 0)
                        {
                            tomatos[y][x - 1] = 1;
                            xq.Enqueue(x - 1);
                            yq.Enqueue(y);
                            count++;
                        }
                        if (x < garo - 1 && tomatos[y][x + 1] == 0)
                        {
                            tomatos[y][x + 1] = 1;
                            xq.Enqueue(x + 1);
                            yq.Enqueue(y);
                            count++;
                        }
                        if (y < sero - 1 && tomatos[y + 1][x] == 0)
                        {
                            tomatos[y + 1][x] = 1;
                            yq.Enqueue(y + 1);
                            xq.Enqueue(x);
                            count++;
                        }
                        if (y > 0 && tomatos[y - 1][x] == 0)
                        {
                            tomatos[y - 1][x] = 1;
                            yq.Enqueue(y - 1);
                            xq.Enqueue(x);
                            count++;
                        }
                    }
                    loop++;
                }
                if (Allripen(tomatos))
                {
                    Console.WriteLine(loop-1);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
