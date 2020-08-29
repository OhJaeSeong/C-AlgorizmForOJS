using System;
using System.Collections.Generic;

namespace CSharpAlgorizm.StringProcess
{
    class Basketball
    {
        static void Main(string[] args)
        {
            int playerNumber = Convert.ToInt16(Console.ReadLine());
            string players = "";
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int k = 0; k < playerNumber; k++)
            {
                players = Console.ReadLine();
                if(!map.ContainsKey(players.Substring(0,1)))
                {
                    map.Add(players.Substring(0,1), 1);
                }
                else
                {
                    map[players.Substring(0, 1)] = map[players.Substring(0, 1)] + 1;
                }
            }
            string list = "";
            foreach (var i in map)
            {
                if(i.Value > 4)
                {
                    list += i.Key;
                }
            }
            if (list.Equals(""))
            {
                Console.WriteLine("PREDAJA");
            }
            else
            {
                char[] ch = list.ToCharArray();
                Array.Sort(ch);
                Console.WriteLine(ch);
            }
        }
    }
}
