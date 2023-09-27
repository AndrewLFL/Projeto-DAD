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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            cbDesc.Items.Clear();
            Modalidade mod = new Modalidade();
            try
            {
                MySqlDataReader r = mod.consultarTodasModalidade();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        cbDesc.Items.Add(r["descricaoModalidade"].ToString());
                    }
                }
                r.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void cbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbDesc.SelectedItem.ToString());
            MySqlDataReader r = mod.consultarModalidade();
            txtPreco.Text = r["precoModalidade"].ToString();
            txtAlunos.Text = r["qtdeAluno"].ToString();
            txtAulas.Text = r["qtdeAulas"].ToString();

        }
    }
}
