using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Segunda : Form
    {
        public bool logado = false;
        public Conexao conn;
        private SqlConnection ConnectOpen;
        

        public Segunda()
        {
            conn = new Conexao();
            InitializeComponent();
            ConnectOpen = conn.ConnectToDatabase();
        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSeg.Clear();
            txtnomeTar.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Segunda(nomeTarefa, tarefaSeg) ");
            sql.Append("Values (@nomeTarefa, @tarefaSeg)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
                command.Parameters.Add(new SqlParameter("@tarefaSeg", txtSeg.Text));
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var consd = new ConsultaS();
            consd.ShowDialog();
            btnExcluir.Visible = true;

            //Verificar se foi selecionado algum item
            if (consd.UsuarioSelecionado == "")
                return;

            var conn = AgendaSemanal.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Segunda where nomeTarefa = '" + consd.UsuarioSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtnomeTar.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtSeg.Text = dt.Rows[0][1].ToString();

            string PerfilSelecionado;

            
        }
        private void LimparTela()
        {
            
            txtnomeTar.Text = "";
            txtSeg.Text = "";
            btnExcluir.Visible = false;

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
            string sql = "Delete from Segunda where nomeTarefa = @nomeTarefa";

            SqlCommand command = null;
            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@nomeTarefa", txtnomeTar.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Excluído com sucesso!");
            LimparTela();
        }

        private void Segunda_Load(object sender, EventArgs e)
        {
            btnExcluir.Visible = false;
        }
    }
}
    

