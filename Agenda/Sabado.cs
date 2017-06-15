using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class Sabado : Form
    {
        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public Sabado()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomeTar.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Sabado(nomeTarefa, tarefaSab) ");
            sql.Append("Values (@nomeTarefa, @tarefaSab)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
                command.Parameters.Add(new SqlParameter("@tarefaSab", txtSab.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Tarefa cadastrada com sucesso!", "Informação");
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }//Fim else 
    }
}
   
