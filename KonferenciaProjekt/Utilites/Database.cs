using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace KonferenciaProjekt
{
    internal class Db
    {
        static MySqlConnectionStringBuilder connStrBldr = new MySqlConnectionStringBuilder()
        {
            Server = "localhost",
            Port = 3306,
            UserID = "root",
            Password = "",
            Database = "konferencia"
        };
        
        public static MySqlConnection Connect { get => new MySqlConnection(connStrBldr.ConnectionString); }
    }
}
