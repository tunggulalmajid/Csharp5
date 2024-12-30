using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    class mobilHonda
    {
        public string warna; // public berati bisa diakses semua kelas
        private int brand; // private berarti hanya dapat diakses dalam kelas yang sama 
        protected string tipe; // protected hampir sama dengan private hanya saja bisa di akses oleh kelas turunan
        internal string kendaraan; // internal berarti hanya dapat di akses oleh assembly yang sama 


        // encapsulation berarti mengamankan data seperti menggunakan private dalam sebuah variabel

    }
    public interface IMobil
    {
        /* interface berarti beberapa fungsi yang dikelompokkan seperti kelas namun fungsi nya berbeda
         untuk memudahkan komponen dalam program dan setiap komonen tidak lah terikat */
    }
    static class mesin // static tidak memerlukan keyword new, todak dapat di turunkan, tidak dapat dibuat objek, isi nya harus memuat static atau tetap
    {
        static int ukuran;
        static void bahanBakar()
        {
            Console.WriteLine("bensin");
        }
    }
}
