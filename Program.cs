using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> rndNums = new List<int>();

            for(int i=0; i <20; i++)
            {
                rndNums.Add(random.Next(1,51));
                Console.WriteLine($"Random Numbers - {rndNums[i]}");
            }

            List<int> sqrNums = new List<int>();
            foreach (int num in rndNums)
            {
                sqrNums.Add(num * num);
            }
            sqrNums.RemoveAll(num => num % 2 == 0);
            foreach (int item in sqrNums)
            {
                Console.WriteLine($"Squared number - {item}");
            }
        }
    }
}
