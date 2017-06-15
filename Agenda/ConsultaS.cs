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
    public partial class ConsultaS : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public string UsuarioSelecionado = "";

        public ConsultaS()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }

        private void ConsultaDias_Load(object sender, EventArgs e)
        {
            var conn = AgendaSemanal.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from Segunda";
            DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }
  }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
