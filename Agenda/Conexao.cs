using System;
using System.Data.SqlClient;
using System.IO;

namespace Agenda
{
    public class Conexao
    {
        SqlConnection conn = null;

        public static object ConnectOpen { get; internal set; }

        public SqlConnection ConnectToDatabase()
        {
            try
            {
                //Criar uma nova instancia
                conn = new SqlConnection();
                var path = AppDomain.CurrentDomain.BaseDirectory?.Replace("bin\\Debug\\", "").Replace("bin\\Release\\", "");

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "Agenda.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
                return conn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}