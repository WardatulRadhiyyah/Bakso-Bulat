using System;
using MySql.Data.MySqlClient;

namespace Bakso_Bulat
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("=========== BAKSO BULAT ===========");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("=========== MENU BAKSO ============");
            Console.WriteLine("===== MENU =========== HARGA ======");
            Connect conn = new Connect();
            Console.WriteLine("Connect to MySql DB. \n");
            using (conn.Connection)
            {
                try
                {
                    conn.Connection.Open();
                    System.Console.WriteLine("Connection is" + conn.Connection.State.ToString() + Environment.NewLine);

                    MySqlCommand command = conn.Connection.CreateCommand();
                    command.CommandText = System.Data.CommandType.Text.ToString();
                    command.CommandText = "Select*from menu_bakso";

                    MySqlDataReader reader = command.ExecuteReader();

                    var data = "No\tMenu\t\tHarga";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data += Environment.NewLine + reader.GetInt32(0) + "|\t" + reader.GetString(1) + "\t" + reader.GetString(2);

                        }
                    }
                    Console.WriteLine(data);
                    System.Console.WriteLine("Connection is" + conn.Connection.State.ToString() + Environment.NewLine);

                    int Pilihan = 0;


                    while (Pilihan != -1)
                    {

                        Console.WriteLine("Masukkan Pilihan Bakso : ");
                        Pilihan = Convert.ToInt32(Console.ReadLine());


                        switch (Pilihan)
                        {
                            case 1:
                                Baksokeju Keju = new Baksokeju();
                                Keju.CustomBakso(Keju.Hargapcs);
                                break;

                            case 2:
                                Baksourat Urat = new Baksourat();
                                Urat.CustomBakso(Urat.Hargapcs);
                                break;

                            case 3:
                                Baksopedas Pedas = new Baksopedas();
                                Pedas.CustomBakso(Pedas.Hargapcs);
                                break;

                            case 4:
                                Baksocuanki Cuanki = new Baksocuanki();
                                Cuanki.CustomBakso(Cuanki.Hargapcs);
                                break;

                            case 5:
                                Baksobiasa Biasa = new Baksobiasa();
                                Biasa.CustomBakso(Biasa.Hargapcs);
                                break;

                                
                        }

                    }

                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    System.Console.WriteLine("Error!" + ex.Message.ToString());
                }
                conn.Connection.Close();
                System.Console.WriteLine("Connection is" + conn.Connection.State.ToString() + Environment.NewLine);
            }       
            
            Harga kalkulasi = new Harga();
            kalkulasi.Cetakharga();
            Console.WriteLine("------------------------------------");


        }
    }
}