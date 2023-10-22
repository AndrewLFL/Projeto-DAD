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
    public partial class FrmAtualizarModalidade : Form
    {

        private ModalidadeControl mc;

        public FrmAtualizarModalidade()
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
                List<int> lista = mc.consultarTodasModalidades();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbId.SelectedItem.ToString());
                String descricao = txtDescricao.Text;
                double preco = double.Parse(txtPreco.Text, new CultureInfo("pt"));
                int qtdeAlunos = Convert.ToInt32(txtQtdeAlunos.Text);
                int qtdeAulas = Convert.ToInt32(txtQtdeAulas.Text);
                int ativo = Convert.ToInt32(cbAtivo.SelectedItem.ToString());
                Modalidade mod = new Modalidade(id, descricao, preco, qtdeAlunos, qtdeAulas, ativo);
                if (mc.atualizar(mod))
                {
                    MessageBox.Show("Modalidade atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar modalidade!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar modalidade: " + ex.Message);
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
                cbAtivo.Text = mod.getSetAtivo.ToString();
                txtPreco.ReadOnly = false;
                txtDescricao.ReadOnly = false;
                txtQtdeAlunos.ReadOnly = false;
                txtQtdeAulas.ReadOnly = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Modalidade: " + ex.Message);
            }
        }
    }
}
