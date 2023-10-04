using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class FrmCadastrarTurma : Form
    {
        public FrmCadastrarTurma()
        {
            InitializeComponent();
            Modalidade conMod = new Modalidade();
            MySqlDataReader r = conMod.consultarTodasModalidade();
            while (r.Read())
            {
                dgvModalidade.Rows.Add(r["descricaoModalidade"].ToString());
            }
        }

        private void FrmCadastrarTurma_Load(object sender, EventArgs e)
        {

        }
    }
}
