using System;
using System.Text;

namespace CSharpAlgorizm.Searching
{
    class PurmutationSearching
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int sum = Convert.ToInt32(input[0]);
            int leastNum = Convert.ToInt32(input[1]);
            if(leastNum > 100)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for(int i = leastNum; i < 101; i++)
                {
                    if(i%2 == 1 && sum%i == 0)
                    {
                        if( (sum/i) - (i / 2) >= 0 && i+1 <= 100)
                        {
                            for(int k = sum/i - i/2; k < sum/i + i/2 + 1; k++)
                            {
                                sb.Append(k + " ");
                            }
                            break;
                        }
                    }else if( i%2 == 0 && sum%i == i/2)
                    {
                        if( sum/i - i/2 + 1 >= 0 && i <= 100)
                        {
                            for(int p = sum/i - i/2 + 1; p < sum/i + i / 2 + 1; p++)
                            {
                                sb.Append(p + " ");
                            }
                            break;
                        }
                    }
                    else if(i == 100)
                    {
                        Console.WriteLine(-1);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
