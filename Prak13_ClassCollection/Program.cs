using Prak13_ClassCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1989";
            mhs1.NamaMhs = "Noey";

            // Membuat Objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1990";
            mhs2.NamaMhs = "Sone";

            // Membuat Objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDsn = "Zero";

            // Membuat Objek List
            List<Mahasiswa> listMhs = new List<Mahasiswa>();
            List<Dosen> listDsn = new List<Dosen>();

            // Menambahkan Elemen List
            listMhs.Add(mhs1);
            listMhs.Add(mhs2);
            listDsn.Add(dosen);

            // Mengakses Elemen List
            Mahasiswa Mhs = listMhs[0];
            Console.WriteLine("{0}, {1}", Mhs.Nim, Mhs.NamaMhs);
            Mahasiswa mhs = listMhs[1];
            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMhs);
            Dosen Dsn = listDsn[0];
            Console.WriteLine("{0}, {1}", Dsn.Nik, Dsn.NamaDsn);
            Console.WriteLine();

            Console.WriteLine("=================");
            Console.WriteLine("  NIM      Nama  ");
            Console.WriteLine("=================");
            foreach (Mahasiswa Mhss in listMhs)
            {
                Console.WriteLine(" {0}      {1} ", Mhss.Nim, Mhss.NamaMhs);
            }
            Console.WriteLine();

            Console.WriteLine("=================");
            Console.WriteLine("  NIK      Nama  ");
            Console.WriteLine("=================");
            foreach (Dosen Dos in listDsn)
            {
                Console.WriteLine(" {0}      {1} ", Dos.Nik, Dos.NamaDsn);
            }

            Console.ReadKey();
        }
    }
}
