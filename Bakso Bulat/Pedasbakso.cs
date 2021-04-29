using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bakso_Bulat
{
    public class Baksopedas : ABakso
    {
        public int Hargapcs = 23000;
        public new void CustomBakso(int Harga)
        {
            base.CustomBakso(Harga);

        }

    }
}
