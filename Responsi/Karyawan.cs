using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

        public Karyawan(string nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;
            Gaji = gaji;

            if (gaji < 0)
            {
                Gaji = 0;
            }
        }
    }
}
