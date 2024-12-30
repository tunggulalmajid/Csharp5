using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    class bangunDatar // kelas awal
    {
        public string warna;
        public double luas;
    }
    class Segitiga : bangunDatar //pewarisan sifat dari suatu kelas
    {
        public double alas {  get; set; }
        public double tinggi {  get; set; }
        public double Luas(double alas, double tinggi)
        {
            double luas = (alas*tinggi)/2;
            return luas;
        }
    }
}
