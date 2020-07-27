using System;

namespace Count_down
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 100; 

            while (v > 0)
            {
                Console.WriteLine("the number is:{0}", v);

                v--; 
            }

        }
    }
}
