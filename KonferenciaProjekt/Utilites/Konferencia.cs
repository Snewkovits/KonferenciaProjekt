using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonferenciaProjekt
{
    internal class Konferencia
    {
        List<Eloadas> eloadasok;
        public List<Eloadas> Eloadasok { get => eloadasok; }

        public Konferencia()
        {
            eloadasok = new List<Eloadas>();
            int eloadasokSzama = 0;

            MySqlConnection conn = Db.Connect;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM eloadasok;";
            conn.Open();
            eloadasokSzama = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();

            for (;0 < eloadasokSzama; eloadasokSzama--)
            {
                string cim = string.Empty; int sorDb = 0, helyDb = 0, index = 0;
                int[,] ertekelesek;

                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT cim FROM eloadasok WHERE eloadasid = @eloadasid";
                cmd.Parameters.Add("@eloadasid", MySqlDbType.Int32).Value = eloadasokSzama;
                cim = cmd.ExecuteScalar().ToString();

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT sorok FROM eloadasok WHERE eloadasid = @eloadasid";
                cmd.Parameters.Add("@eloadasid", MySqlDbType.Int32).Value = eloadasokSzama;
                sorDb = int.Parse(cmd.ExecuteScalar().ToString());

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT szekek FROM eloadasok WHERE eloadasid = @eloadasid";
                cmd.Parameters.Add("@eloadasid", MySqlDbType.Int32).Value = eloadasokSzama;
                helyDb = int.Parse(cmd.ExecuteScalar().ToString());

                ertekelesek = new int[sorDb, helyDb];

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT sor, szek, ertekeles FROM ertekelesek WHERE eloadasid = @eloadasid";
                cmd.Parameters.Add("@eloadasid", MySqlDbType.Int32).Value = eloadasokSzama;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    if (reader.GetInt32("sor") <= sorDb && reader.GetInt32("szek") <= helyDb)
                        ertekelesek[reader.GetInt32("sor") - 1, reader.GetInt32("szek") - 1] = reader.GetInt32("ertekeles");

                conn.Close();

                eloadasok.Add(new Eloadas(cim, sorDb, helyDb, ertekelesek));
            }
        }
    }
}
