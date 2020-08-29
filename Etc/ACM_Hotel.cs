using System;

namespace CSharpAlgorizm
{
    class ACM_Hotel
    {
        static void Main(string[] args)
        {
            string caseNum = Console.ReadLine();
            int caseNumber = Convert.ToInt16(caseNum);
            for (int c = 0; c < caseNumber; c++)
            {
                string[] testCase = Console.ReadLine().Split();
                int h = int.Parse(testCase[0]);
                int w = int.Parse(testCase[1]);
                int n = int.Parse(testCase[2]);
                int Place = 101; int people = 1;
                for (int ww = 0; ww < w; ww++)
                {
                    for(int hh = 0; hh < h; hh++)
                    {
                        if(people == n)
                        {
                            Console.WriteLine(Place);
                            break;
                        }else if (hh == h-1)
                        {
                            continue;
                        }
                        else
                        {
                            people++;
                            Place += 100;
                        }
                    }
                    if (people == n)
                    {
                        break;
                    }
                    else
                    {
                        Place = Place - 100 * (h-1) + 1;
                        people++;
                    }
                }
            }
        }
    }
}
