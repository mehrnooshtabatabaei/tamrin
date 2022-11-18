using System;
using System.IO;

public class Demo
{
    public class Power
    {
        public long power_calc(int n)
        {

            double pow2 = n * n;
            double pow3 = n * n * n;
            Console.WriteLine("power of 2: " + pow2);
            Console.WriteLine("power of 3: " + pow3);
            return 0;
        }
    }



    public static void Main(string[] args)
    {
        Power myPower = new Power();
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        myPower.power_calc(input);
        Console.Read();
    }

}