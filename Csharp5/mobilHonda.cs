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

    }
}
