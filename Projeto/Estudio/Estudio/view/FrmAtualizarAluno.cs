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
    public partial class FrmAtualizarAluno : Form
    {

        private AlunoControl ac;
        public FrmAtualizarAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ac.consultar(mtxtCpf.Text))
                {
                    Aluno al = ac.buscar(mtxtCpf.Text);
                    txtNome.Text = al.getSetNome;
                    txtEndereco.Text = al.getSetEndereco;
                    txtNum.Text = al.getSetNumero;
                    txtBairro.Text = al.getSetBairro;
                    txtComplemento.Text = al.getSetComplemento;
                    mtxtCep.Text = al.getSetCep;
                    txtCidade.Text = al.getSetCidade;
                    txtEstado.Text = al.getSetEstado;
                    mtxtTel.Text = al.getSetTelefone;
                    txtEmail.Text = al.getSetEmail;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!");
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ac.consultar(mtxtCpf.Text))
            {
                Aluno al = new Aluno(mtxtCpf.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComplemento.Text, mtxtCep.Text, txtCidade.Text, txtEstado.Text, mtxtTel.Text, txtEmail.Text);
                if (ac.atualizar(al))
                {
                    MessageBox.Show("Aluno atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar aluno!");
                }
            }
            else
            {
                MessageBox.Show("Aluno não encontrado!");
            }
        }
    }
}
