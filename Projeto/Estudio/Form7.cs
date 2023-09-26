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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade m = new Modalidade(cbDesc.SelectedItem.ToString());
                if (m.excluirModalidade())
                {
                    this.atualizaComboBox(); // tem que ver porque não ta atualizando 
                    MessageBox.Show("Modalidade excluída com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
