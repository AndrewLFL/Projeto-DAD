using Estudio.control;
using Estudio.model;
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
            cbDescricao.Items.Clear();
            try
            {
                List<String> lista = mc.consultarTodasModalidadesAtivas();
                foreach (String item in lista)
                {
                    cbDescricao.Items.Add(item);
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
                if (cbDescricao.SelectedItem == null)
                    return;
                if (mc.excluir(cbDescricao.SelectedItem.ToString()))
                {
                    MessageBox.Show("Modalidade excluída!");
                    atualizaComboBox();
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
    }
}
