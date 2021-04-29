using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Bakso_Bulat
{
    public class Connect
    {
        private static string connectionString = "server=localhost;port=3306; uid=wrdiyah;"+ "pwd=858617;database=baksobulat; charset=utf8; sslMode=none";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public MySqlConnection Connection
        {
            get { return connection;}
        }
    }
}
