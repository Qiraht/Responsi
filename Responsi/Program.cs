using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrograman 18-S1IF-08 tahun 2018/2019";
            Karyawan ObjKaryawan = new Karyawan("190124", "Paijo", 3000000);
            Karyawan ObjKaryawan2 = new Karyawan("190125", "Jono", 2000000);

            Hasil(ObjKaryawan, ObjKaryawan2);

            Console.WriteLine("Asyiiiiikkkk Kenaikan Gaji 10%");
            Console.WriteLine();

            var result = (0.10 * ObjKaryawan.Gaji) + ObjKaryawan.Gaji;
            var result2 = (0.10 * ObjKaryawan2.Gaji) + ObjKaryawan2.Gaji;
            ObjKaryawan.Gaji = Convert.ToInt32(result);
            ObjKaryawan2.Gaji = Convert.ToInt32(result2);

            Hasil(ObjKaryawan, ObjKaryawan2);

            Console.ReadKey();
        }

        static void Hasil(Karyawan karyawan, Karyawan karyawan2)
        {
            Console.WriteLine("No. Nik\t   Nama\t Gaji");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("1.  {0} {1}", karyawan.Nik, karyawan.Nama);
            Console.Write(" {0}", karyawan.Gaji);
            Console.WriteLine();
            Console.Write("2.  {0} {1}", karyawan2.Nik, karyawan2.Nama);
            Console.WriteLine("  {0}", karyawan2.Gaji);
            Console.WriteLine();
        }
    }
}
