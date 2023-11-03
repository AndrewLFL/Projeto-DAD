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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estudio.view
{
    public partial class FrmExcluirAluno : Form
    {
        AlunoTurmaControl atc;
        AlunoControl ac;
        TurmaControl tc;
        public FrmExcluirAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
            atc = new AlunoTurmaControl();
            tc = new TurmaControl();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            cbCpf.Items.Clear();
            try
            {
                List<String> lista = ac.consultarTodosAlunosAtivos();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String cpf = cbCpf.SelectedItem.ToString();
            List<int> lista = atc.consultarTodasTurmasPorAluno(cpf);
            if (ac.excluir(cbCpf.SelectedItem.ToString()))
            {
                MessageBox.Show("Aluno excluído!");
                atualizaComboBox();
                if(atc.excluirMatriculasPorAluno(cpf))
                {
                    foreach(int id in lista) 
                    {
                        int qtdeAlunos = atc.qtdeAlunosMatriculados(id);
                        tc.atualizarNumAlunos(id, qtdeAlunos);
                    }
                }
                else 
                {
                    MessageBox.Show("Houve um problema ao excluir as matriculas relacionadas a esse aluno!");
                }
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
            }
            else
            {                         
                MessageBox.Show("Erro ao excluir!");                 
            }
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
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
        }
    }
}
