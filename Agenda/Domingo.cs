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
    public partial class Domingo : Form
    {
        public bool logado = false;
        public Conexao conn;
        private SqlConnection ConnectOpen;

        public string nometarefa = "";

        public Domingo()
        {
            InitializeComponent();
        }
     

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDom.Clear();
            txtnomeTar.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
