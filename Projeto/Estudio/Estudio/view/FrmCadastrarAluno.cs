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
    public partial class FrmCadastrarAluno : Form
    {
        AlunoControl ac;

        public FrmCadastrarAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtCpf.Text == "" || txtNome.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtComplemento.Text == "" || mtxtCep.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || mtxtTel.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }
                String cpf = mtxtCpf.Text;
                String nome = txtNome.Text;
                String endereco = txtEndereco.Text;
                String numero = txtNum.Text;
                String bairro = txtBairro.Text;
                String complemento = txtComplemento.Text;
                String cep = mtxtCep.Text;
                String cidade = txtCidade.Text;
                String estado = txtEstado.Text;
                String tel = mtxtTel.Text;
                String email = txtEmail.Text;
                Aluno al = new Aluno(cpf, nome, endereco, numero, bairro, complemento, cep, cidade, estado, tel, email);
                if (ac.cadastrar(al))
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

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ac.consultar(mtxtCpf.Text))
                {
                    MessageBox.Show("Esse cpf já está sendo usado!");
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtComplemento.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtEndereco.ReadOnly = true;
                    txtEstado.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtNum.ReadOnly = true;
                    mtxtCep.ReadOnly = true;
                    mtxtTel.ReadOnly = true;
                }
                else
                {
                    txtBairro.ReadOnly = false;
                    txtCidade.ReadOnly = false;
                    txtComplemento.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtEndereco.ReadOnly = false;
                    txtEstado.ReadOnly = false;
                    txtNome.ReadOnly = false;
                    txtNum.ReadOnly = false;
                    mtxtCep.ReadOnly = false;
                    mtxtTel.ReadOnly = false;
                }
            }
        }
    }
}
