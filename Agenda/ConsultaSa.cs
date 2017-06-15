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
    public partial class ConsultaSa : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public string UsuarioSelecionado = "";
        public ConsultaSa()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ConsultaSa_Load(object sender, EventArgs e)
        {
            var conn = AgendaSemanal.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from Sabado";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView5.DataSource = dt;
            }
        }

        private void dataGridView6_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }
    }
}
