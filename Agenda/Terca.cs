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
    public partial class Terca : Form
    {
        public bool logado = false;
        public Conexao conn;
        private SqlConnection ConnectOpen;

        public Terca()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }//Fim else 


        private void LimparTela()
        {

            txtnomeTar.Text = "";
            txtTer.Text = "";
            btnExcluir.Visible = false;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var conn = AgendaSemanal.ConnectOpen;

            //Confirmar exclusão
            DialogResult result = MessageBox.Show("Deseja REALMENTE excluir?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //Caso o usuário dê ok, a exclusão prossegue
            if (!result.Equals(DialogResult.OK))
                return; //caso cancele, o código abaixo não será excutado.

            //Buscar usuário selecionado
            string sql = "Delete from Terca where nomeTarefa = @nomeTarefa";

            SqlCommand command = null;
            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Excluído com sucesso!");
            LimparTela();
        }

        private void Terca_Load(object sender, EventArgs e)
        {
            btnExcluir.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTer.Clear();
            txtnomeTar.Clear();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Terca(nomeTarefa, tarefaTer) ");
            sql.Append("Values (@nomeTarefa, @tarefaTer)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
                command.Parameters.Add(new SqlParameter("@tarefaTer", txtTer.Text));
                command.ExecuteNonQuery();
                LimparTela();
                MessageBox.Show("Tarefa cadastrada com sucesso!", "Informação");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            btnExcluir.Visible = true;
            var consT = new ConsultaT();
            consT.ShowDialog();

            //Verificar se foi selecionado algum item
            if (consT.UsuarioSelecionado == "")
                return;

            var conn = AgendaSemanal.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Terca where nomeTarefa = '" + consT.UsuarioSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtnomeTar.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtTer.Text = dt.Rows[0][1].ToString();

            string PerfilSelecionado;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

