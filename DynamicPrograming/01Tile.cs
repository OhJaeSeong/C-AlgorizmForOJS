using System;

namespace CSharpAlgorizm
{
    class _01Tile
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] nCount = new long[n+1];
            if(n == 0)
            {
                nCount[0] = 0;
            }
            else
            {
                nCount[0] = 1;
                nCount[1] = 1;
                if (n > 1)
                {
                    for (int k = 2; k < n + 1; k++)
                    {
                        nCount[k] = nCount[k - 2] + nCount[k - 1];
                        nCount[k] = nCount[k] % 15746;
                    }
                }
            }
           
            Console.WriteLine(nCount[n]);
        }
    }
}
