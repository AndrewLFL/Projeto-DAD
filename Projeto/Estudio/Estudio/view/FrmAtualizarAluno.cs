using Estudio.control;
using Estudio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            cbCpf.Items.Clear();
            try
            {
                List<String> lista = ac.consultarTodosAlunos();
                foreach (String item in lista)
                {
                    cbCpf.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtComplemento.Text == "" || mtxtCep.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || mtxtTel.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            Aluno al = new Aluno(cbCpf.SelectedItem.ToString(), txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComplemento.Text, mtxtCep.Text, txtCidade.Text, txtEstado.Text, mtxtTel.Text, txtEmail.Text, int.Parse(cbAtivo.SelectedItem.ToString()));
            if (ac.atualizar(al))
            {
                MessageBox.Show("Aluno atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar aluno!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtEstado.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtNum.ReadOnly = true;
            mtxtCep.ReadOnly = true;
            mtxtTel.ReadOnly = true;
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNum.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            mtxtCep.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            mtxtTel.Text = "";
            txtEmail.Text = "";
            cbCpf.Text = "";
            cbAtivo.Text = "";
        }

        private void cbCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String cpf = cbCpf.SelectedItem.ToString();
                Aluno al = ac.buscar(cpf);
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
                cbAtivo.Text = al.getSetAtivo.ToString();
                txtEmail.ReadOnly = false;
                txtBairro.ReadOnly = false;
                txtCidade.ReadOnly = false;
                txtComplemento.ReadOnly = false;
                txtEndereco.ReadOnly = false;
                txtEstado.ReadOnly = false;
                txtNome.ReadOnly = false;
                txtNum.ReadOnly = false;
                mtxtCep.ReadOnly = false;
                mtxtTel.ReadOnly = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
        }
    }
}
