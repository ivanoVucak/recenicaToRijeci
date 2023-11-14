using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recenicaToRijeci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;

            Console.Write("Napisi neku recenicu --> ");
            recenica = Convert.ToString(Console.ReadLine());

            string[] rijeci = recenica.Split(' ');
            Console.Write(rijeci.First() + " " + rijeci.Last());

            Console.ReadKey();
        }
    }
}
