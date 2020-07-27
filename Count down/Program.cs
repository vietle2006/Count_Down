using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Count_down
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;


            Console.WriteLine("Enter a number that's higher than 0:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Loading.......");
            StartDelay();

            int v = x;

          


            while (v > 0)
            {
             
               
                

                v--;

                if (v % 2 == 0)
                {
                    Console.WriteLine("the number is:{0}", v);
                    Console.Beep(75, 1000);
                    
                    

                }
                else
                {
                    Console.WriteLine("the number is:{0}", v);
                    DelayTime();

                }






            }


            void DelayTime()
            {
                Thread.Sleep(1000);
            }

            void StartDelay()
            {
                Thread.Sleep(5000);
            }


            Console.Read();

        }  
            
    }
}
