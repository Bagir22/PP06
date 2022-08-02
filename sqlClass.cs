using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PopryzhenokPP06
{
    internal class sqlClass
    {
        static string connectionString = "server=localhost;user=root;password=root;database=pp06";
        internal static MySqlConnection conn = new MySqlConnection(connectionString);
    }
}
