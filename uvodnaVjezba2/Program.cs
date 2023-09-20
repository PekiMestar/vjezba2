using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d;
            double avg = 0;

            a = 10;
            b = 7;

            c = 12.5;
            d = 16.7;

            avg = (a + b + c + d) / 4;

            Console.WriteLine("Prosječna vrijednost je " + avg);
            Console.ReadKey();
        }
    }
}
