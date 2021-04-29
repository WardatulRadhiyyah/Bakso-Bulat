using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakso_Bulat
{
   
        public class Baksobiasa : ABakso
        {
            public int Hargapcs = 20000;
            public new void CustomBakso(int Harga)
            {
                base.CustomBakso(Harga);


            }

        }
    

}

