using System;

namespace CSharpAlgorizm
{
    class DeliverSugar
    {
        static void Main(string[] args)
        {
            string sugarSum = Console.ReadLine();
            int sugars = Convert.ToInt32(sugarSum);
            int sum = sugars;
            if (sugars%5 == 0)
            {
                Console.WriteLine(sugars / 5);
            }
            else if((sugars%5)%3 == 0 && ((sugars%5) > 2))
            {
                Console.WriteLine((sugars / 5) + (sugars % 5) / 3);
            }
            else if(sugars%3 == 0)
            {
                int b = sugars / 3; int loop = 0;
                for (int i = 0; i < b; i++)
                {
                    sum -= 15;
                    if (sum < 0)
                    {
                        Console.WriteLine(loop + (sugars-loop*5)/3);
                        break;
                    }
                    else
                    {
                        loop += 3;
                    }
                }
            }
            else
            {
                for(int k = 1; k < (sugars/3)+1; k++)
                {
                    sum -= 5;
                    if (sum < 0)
                    {
                        sum += 5;
                        if (sum%3 == 0)
                        {
                            Console.WriteLine(k - 1 + (sum / 3));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(-1);
                            break;
                        } 
                    }
                    if (sum%3 == 0 && sum%5 != 0 && sum < 15)
                    {
                        Console.WriteLine(k + (sum / 3));
                        break;
                    }
                }
            }
        }
    }
}
