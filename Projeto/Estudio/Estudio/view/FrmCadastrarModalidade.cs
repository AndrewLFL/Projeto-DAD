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
    public partial class FrmCadastrarModalidade : Form
    {
        public FrmCadastrarModalidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ModalidadeControl mc = new ModalidadeControl();
            try
            {
                if (txtDescricao.Text == "" || txtPreco.Text == "" || txtQtdeAlunos.Text == "" || txtQtdeAulas.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }
                String descricao = txtDescricao.Text;
                double preco = double.Parse(txtPreco.Text, new CultureInfo("pt"));
                int qtdeAlunos = Convert.ToInt32(txtQtdeAlunos.Text);
                int qtdeAulas = Convert.ToInt32(txtQtdeAulas.Text);
                Modalidade mod = new Modalidade(descricao, preco, qtdeAlunos, qtdeAulas);
                if (mc.cadastrar(mod))
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("O cadastro não pode ser realizado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar aluno: " + ex.Message);
            }
        }
    }
}
