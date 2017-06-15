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
    public partial class Sexta : Form
    {
        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public Sexta()
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
            txtnomeTar.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Sexta(nomeTarefa, tarefaSex) ");
            sql.Append("Values (@nomeTarefa, @tarefaSex)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
                command.Parameters.Add(new SqlParameter("@tarefaSex", txtSex.Text));
                command.ExecuteNonQuery();
                LimparTela();
                MessageBox.Show("Tarefa cadastrada com sucesso!", "Informação");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }//Fim else 

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            var conss = new ConsultaSe();
            conss.ShowDialog();
            btnexcluir.Visible = true;

            //Verificar se foi selecionado algum item
            if (conss.UsuarioSelecionado == "")
                return;

            var conn = AgendaSemanal.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Sexta where nomeTarefa = '" + conss.UsuarioSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtnomeTar.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtSex.Text = dt.Rows[0][1].ToString();

            string PerfilSelecionado;


        }
        private void LimparTela()
        {

            txtnomeTar.Text = "";
            txtSex.Text = "";
            btnexcluir.Visible = false;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var conn = AgendaSemanal.ConnectOpen;

            //Confirmar exclusão
            DialogResult result = MessageBox.Show("Deseja REALMENTE excluir?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //Caso o usuário dê ok, a exclusão prossegue
            if (!result.Equals(DialogResult.OK))
                return; //caso cancele, o código abaixo não será excutado.

            //Buscar usuário selecionado
            string sql = "Delete from Sexta where nomeTarefa = @nomeTarefa";

            SqlCommand command = null;
            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Excluído com sucesso!", "Informação");
            LimparTela();
        }
    }
}
