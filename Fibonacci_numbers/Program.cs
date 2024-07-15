using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Serie_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c;
            Console.WriteLine("Introduzca hasta que generación desea ver la sucesión de Fibonacci");
            string sres= Console.ReadLine();
            int res= Convert.ToInt32(sres);
            Console.WriteLine("La serie de Fibonacci es la siguiente:");
            for (int i = 0; i <= res; i++) 
            {
                Console.WriteLine($"{i}) {a}.");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
