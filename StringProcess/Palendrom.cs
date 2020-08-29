using System;

namespace CSharpAlgorizm.StringProcess
{
    class Palendrom
    {//10988 팰린드롬
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int len = word.Length;
            if(len == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for(int n = 0; n < len/2; n++)
                {
                    if(word.Substring(n,1) != word.Substring(len - n - 1, 1))
                    {
                        Console.WriteLine(0);
                        break;
                    }
                    if(n == (len/2)-1)
                    {
                        Console.WriteLine(1);
                    }
                }
            }
        }
    }
}
