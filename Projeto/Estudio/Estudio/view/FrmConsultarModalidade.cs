using Estudio.control;
using Estudio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.view
{
    public partial class FrmConsultarModalidade : Form
    {

        private ModalidadeControl mc;

        public FrmConsultarModalidade()
        {
            InitializeComponent();
            mc = new ModalidadeControl();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            cbId.Items.Clear();
            try
            {
                List<int> lista = mc.consultarTodasModalidadesAtivasId();
                foreach (int item in lista)
                {
                    cbId.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Modalidade mod = mc.buscar(Convert.ToInt32(cbId.SelectedItem.ToString()));
                txtPreco.Text = mod.getSetPreco.ToString();
                txtDescricao.Text = mod.getSetDescricao;
                txtQtdeAlunos.Text = mod.getSetQtdeAlunos.ToString();
                txtQtdeAulas.Text = mod.getSetQtdeAulas.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Modalidade: " + ex.Message);
            }
        }
    }
}
