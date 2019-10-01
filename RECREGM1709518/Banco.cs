using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RECREGM1709518
{
    public class Banco
    {
        private static string Strconn;

        public static MySqlCommand Abrir()
        {
            Strconn = @"";
            MySqlConnection cn = new MySqlConnection(Strconn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }

        public static void Fechar(MySqlCommand comm)
        {
            var cn = comm.Connection;
            if (cn.State == ConnectionState.Open)
            {
                comm.Connection.Close();
            }
        }
    }
}
