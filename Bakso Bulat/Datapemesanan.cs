using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakso_Bulat
{
     public class Harga
    {
        private static int TotalHarga;
        public void HitungHarga(int Harga)
        {
            TotalHarga += Harga;
        }
        public void Cetakharga()
        {
            Console.WriteLine("Total Harga Pesanan  : " + TotalHarga);
        }
    }

}

