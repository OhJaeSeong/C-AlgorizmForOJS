using System;
using System.Text;

namespace CSharpAlgorizm
{
    class FindingNumber
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] nStr = Console.ReadLine().Split();
            int[] arrayN = new int[nStr.Length];
            for (int p = 0; p < nStr.Length; p++)
            {
                arrayN[p] = int.Parse(nStr[p]);
            }
            Array.Sort(arrayN);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] mStr = Console.ReadLine().Split();
            int[] arrayM = new int[mStr.Length];
            for (int p = 0; p < mStr.Length; p++)
            {
                arrayM[p] = int.Parse(mStr[p]);
            }
            int currentPlace = 0; int searchNum = 0;
            int top = arrayN.Length; int low = 0;
            int center = (top +low)/2;
            while (currentPlace < m)
            {
                searchNum = arrayM[currentPlace];
                while (true)
                {
                    if (top - low < 5)
                    {
                        for (int j = low; j < top; j++)
                        {
                            if (arrayN[j] == searchNum)
                            {
                                sb.Append(1).Append("\n");
                                break;
                            }
                            if (j == top - 1)
                            {
                                sb.Append(0).Append("\n");
                            }
                        }
                        break;
                    }
                    center = (top + low) / 2;

                    if (arrayN[center] == searchNum)
                    {
                        sb.Append(1).Append("\n");
                        break;
                    }else if (arrayN[center] >= searchNum)
                    {
                        top = center;
                    }else
                    {
                        low = center;
                    }
                }
                currentPlace++;
                top = arrayN.Length; low = 0;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
