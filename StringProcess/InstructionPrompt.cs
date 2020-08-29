using System;

namespace CSharpAlgorizm.StringProcess
{
    class InstructionPrompt
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt16(Console.ReadLine());
            string[] inst = new string[num];
            string answer = "";
            for (int p = 0; p < num; p++)
            {
                inst[p] = Console.ReadLine();
            }
            for (int len = 0; len < inst[0].Length; len++)
            {
                string one = inst[0].Substring(len , 1);
                for(int n = 0; n < num; n++)
                {
                    if (inst[n].Substring(len,1) != one)
                    {
                        answer += "?";
                        break;
                    }
                    if(n == num-1)
                    {
                        answer += one;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
