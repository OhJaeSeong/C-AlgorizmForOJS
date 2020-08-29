using System;

namespace CSharpAlgorizm
{
    class beeHouse
    {
        static void Main(string[] args)
        {
            string whatNum = Console.ReadLine();
            int Num = Convert.ToInt32(whatNum);
            int multiple = 0;
            if (Num == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Num -= 1;
                while (Num > 0)
                {
                    multiple += 1;
                    Num -= 6 * multiple;
                }
                Console.WriteLine(multiple+1);
            }
        }
    }
}
