using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class AgendaSemanal : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public AgendaSemanal()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSeg_Click(object sender, EventArgs e)
        {
            var seg = new Segunda();
            seg.Show();
        }

        private void btnTer_Click(object sender, EventArgs e)
        {
            var ter = new Terca();
            ter.Show();
        }

        private void btnQuart_Click(object sender, EventArgs e)
        {
            var qua = new Quarta();
            qua.Show();
        }

        private void btnQuint_Click(object sender, EventArgs e)
        {
            var qui = new Quinta();
            qui.Show();
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            var sex = new Sexta();
            sex.Show();
        }

        private void btnSab_Click(object sender, EventArgs e)
        {
            var sab = new Sabado();
            sab.Show();
        }

        private void btnDom_Click(object sender, EventArgs e)
        {
            var dom = new Domingo();
            dom.Show();

            MessageBox.Show("Não é necessário anotar o dia de domingo!Revisar os dias anteriores!");

            Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


        }
    }
}
