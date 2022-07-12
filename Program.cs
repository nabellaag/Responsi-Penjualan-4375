using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman 21.11.4375";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;
                    case 2:
                        TampilPenjualan();
                        break;
                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Pada Aplikasi\n");
            Console.WriteLine("1. Tambahkan Penjualan");
            Console.WriteLine("2. Tampilkan penjualan");
            Console.WriteLine("3. Keluar");

        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("=========================");
            Console.WriteLine("Tambah Data Penjualan\n ");
            Console.WriteLine("Nota : ");
            penjualan.Nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Nama Customer : ");
            string.Nama = Console.ReadLine();
                Console.WriteLine("Jenis [T/K] : ");
            string JenisPembayaran = Console.ReadLine();
            penjualan.JenisPembayaran = (JenisPembayaran == "T" || JenisPembayaran == "K") ? "Tunai " ; "Kredit";
                Console.WriteLine("total nota : ");
            penjualan.Total_Nota = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int noUrut = 0;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Data Penjualan Hari Ini");
            //untuk memanggil array menggunakan foreach
            foreach(Penjualan penjualan in daftarPenjualan)
            {
                noUrut++;
                Console.WriteLine("{0}, {1}, {2}, {3}", noUrut, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.JenisPembayaran, penjualan.Total_Nota);

            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data tidak ada");//Data tidak ditemuka
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
