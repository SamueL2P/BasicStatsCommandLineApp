using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatsCommandLineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue ,  min = int.MaxValue ,sum = 0 ,currentNum = 0 , count = args.Length;
            double average = 0;


            for (int i = 0; i < args.Length; i++)
            {
                currentNum = Convert.ToInt32(args[i]);

                if (currentNum > max)
                    max = currentNum;

                if (currentNum < min)
                    min = currentNum;

                sum += currentNum;
            }
            average = (double)sum / args.Length;
            Console.WriteLine("Count:" + count + "\nMin: " + min + "\nMax: "+ max + "\nSum : "+ sum + "\nAverage : "+ average);

        }
    }
}
