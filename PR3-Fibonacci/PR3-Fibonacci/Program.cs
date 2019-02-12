using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=7,f=0,f1=0,f2=0;
            Console.WriteLine("Fibonacci");
            if (n == 0)
            {
                f = 0;
            }
            else if(n==1)
            {
                f = 1;
            }
            else
            {
                f1 = 0;
                f2 = 1;
                Console.WriteLine(f1);
                Console.WriteLine(f2);
                for(int i=2;i<=n;i++)
                {
                    f = f1 + f2;
                    f1 = f2;
                    f2 = f;
                    Console.WriteLine("" + f);
                }
                
            }
            Console.ReadKey();
            
        }
    }
}
