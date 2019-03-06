using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyClassLib;
using MyClassLib.WordOfTanks;

namespace Day7__Tanks_
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Random rand = new Random();
            Tank[] T34 = new Tank[size];
            Tank[] pantera = new Tank[5];
            Tank[] panthers = new Tank[size];

            for (int i = 0; i < size; i++)
            {
                panthers[i] = new Tank();
            }
            for (int i = 0; i < size; i++)
            {
                T34[i] = new Tank("T34", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            }

            for (int i = 0; i < size; i++)
            {
                pantera[i] = new Tank("pantera", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            }

            for (int i = 0; i < 5; i++)
            {
                T34[i].Print();
                pantera[i].Print();
                panthers[i] = new Tank();
                panthers[i] = T34[i] * pantera[i];
                Console.WriteLine("+++++++++++++++++++++");
                Console.WriteLine($"В {i + 1} бою победил");
                panthers[i].Print();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
