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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesc.Text == "")
                {
                    throw new Exception();
                }

                Modalidade modalidade = new Modalidade(txtDesc.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtAlunos.Text), Convert.ToInt32(txtAulas.Text));
                if (modalidade.cadastrarModalidade())
                {
                    MessageBox.Show("Modalidade cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Houve um erro ao cadastrar a modalidade");
                }

                txtDesc.Text = "";
                txtPreco.Text = "";
                txtAlunos.Text = "";
                txtAulas.Text = "";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
