using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Count_down
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;


            Console.WriteLine("Enter a number that's higher than 0:");
            x  = Convert.ToInt32(Console.ReadLine());


            int v = x;

            

            

            while (v > 0)
            {
                Console.WriteLine("the number is:{0}", v);

                v--; 
            }

            
            

        }
    }
}
