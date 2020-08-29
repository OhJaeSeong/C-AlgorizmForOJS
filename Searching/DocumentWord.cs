using System;

namespace CSharpAlgorizm.Searching
{
    class DocumentWord
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int count = 0;
            int len = b.Length; 
            for (int x = 0; x < a.Length-b.Length+1; x++)
            {
                if(a.Substring(x, len) == b)
                {
                    count++;
                    x += len - 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
