using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bmm_kmm
{
    class Program
    {
        public class Kmm_Bmm
        {
            int x1 = 0, x2 = 0, x3 = 0, k1 = 0, k2 = 0;
            int a = 0, b = 0;
            int bmm = 0, kmm = 0;


            public void calculate(int a, int b)
            {
                x1 = (a % b);
                x2 = (b % x1);
                x3 = (x1 % x2);
                if (x3 == 0)
                {
                    bmm = x2;

                    k1 = (a / bmm);
                    k2 = (k1 * b);
                    kmm = k2;
                }
                Console.Write("\na: {0} \nb: {1}\nbmm: {2} \nkmm: {3}", a, b, bmm, kmm);
            }

        }



        static void Main(string[] args)
        {
            Kmm_Bmm my_kmm_bmm = new Kmm_Bmm();
            
            Console.Write("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = int.Parse(Console.ReadLine());

            my_kmm_bmm.calculate(a, b);

            Console.ReadLine();
        }
    }
}
