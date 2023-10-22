using Estudio.control;
using Estudio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.view
{
    public partial class FrmExcluirModalidade : Form
    {

        private ModalidadeControl mc;

        public FrmExcluirModalidade()
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


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                TurmaControl tc = new TurmaControl();
                if (cbId.SelectedItem == null)
                    return;
                if (mc.excluir(Convert.ToInt32(cbId.SelectedItem.ToString())))
                {
                    MessageBox.Show("Modalidade excluída!");
                    if (tc.consultarPorModalidade(Convert.ToInt32(cbId.SelectedItem.ToString())))
                    {
                        if(tc.excluirPorModalidade(Convert.ToInt32(cbId.SelectedItem.ToString())))
                        {
                            MessageBox.Show("Turmas relacionadas a essa modalidade também foram excluídas!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir as turmas relacionadas a essa modalidade!");
                        }
                    }
                    atualizaComboBox();
                    txtPreco.Text = "";
                    txtDescricao.Text = "";
                    txtQtdeAlunos.Text = "";
                    txtQtdeAulas.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir a modalidade!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir: " + ex.Message);
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
