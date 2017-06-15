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
    public partial class Quarta : Form
    {
        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public Quarta()
        {

            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
        

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            var conn = AgendaSemanal.ConnectOpen;

            //Confirmar exclusão
            DialogResult result = MessageBox.Show("Deseja REALMENTE excluir?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //Caso o usuário dê ok, a exclusão prossegue
            if (!result.Equals(DialogResult.OK))
                return; //caso cancele, o código abaixo não será excutado.

            //Buscar usuário selecionado
            string sql = "Delete from Quarta where nomeTarefa = @nomeTarefa";

            SqlCommand command = null;
            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Excluído com sucesso!");
            LimparTela();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnExcluir.Visible = true;
            var consQ = new ConsultaQ();
            consQ.ShowDialog();

            //Verificar se foi selecionado algum item
            if (consQ.UsuarioSelecionado == "")
                return;

            var conn = AgendaSemanal.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Quarta where nomeTarefa = '" + consQ.UsuarioSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtnomeTar.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtQua.Text = dt.Rows[0][1].ToString();

            string PerfilSelecionado;
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtQua.Clear();
            txtnomeTar.Clear();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Quarta(nomeTarefa, tarefaQua) ");
            sql.Append("Values (@nomeTarefa, @tarefaQua)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
                command.Parameters.Add(new SqlParameter("@tarefaQua", txtQua.Text));
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
        //Fim else 
        private void LimparTela()
        {

            txtnomeTar.Text = "";
            txtQua.Text = "";
            btnExcluir.Visible = false;

        }

        private void Quarta_Load(object sender, EventArgs e)
        {
            btnExcluir.Visible = false;
        }
    }
}

