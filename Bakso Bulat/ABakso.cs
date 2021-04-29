using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Bakso_Bulat
{
    public abstract class ABakso
    {
        public void CustomBakso(int Harga)
        {
            int input = 0;
            Console.WriteLine("======== PILIHAN TAMBAHAN ===========");
            Console.WriteLine("| Masukkan 1 untuk YA | 0 untuk TIDAK |");
            Console.WriteLine("Apakah Pakai Bihun ? ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1) { Harga += 2000; }
            Console.WriteLine("Apakah Pakai Mie   ?");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1) { Harga += 3000; }
            Console.WriteLine("Apakah Pakai Telur ? ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1) { Harga += 3000; }
            Console.WriteLine("Apakah Pakai Tahu  ? ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1) { Harga += 2000; }
            Console.WriteLine("Total Harga 1 Porsi: " + Harga);

            Console.WriteLine("Masukkan -1 jika tidak ada pesanan lagi!!");
            Harga kalkulasi = new Harga();
            kalkulasi.HitungHarga(Harga);


        }

    }
}

