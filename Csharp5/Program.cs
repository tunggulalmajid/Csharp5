using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segitiga segitiga = new Segitiga();
            segitiga.alas = 20;
            segitiga.tinggi = 10;
            Console.Write("luas segitiga adalah >> ");
            Console.WriteLine(segitiga.Luas(segitiga.alas,segitiga.tinggi));

        }
    }
}
