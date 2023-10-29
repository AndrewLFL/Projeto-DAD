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
    public partial class FrmDesmatricularAluno : Form
    {

        AlunoControl ac;
        TurmaControl tc;
        AlunoTurmaControl tac;
        ModalidadeControl mc;

        public FrmDesmatricularAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
            tc = new TurmaControl();
            tac = new AlunoTurmaControl();
            mc = new ModalidadeControl();

            atualizarCbId();
        }

 

        public void atualizarCbId()
        {
            cbId.Items.Clear();
            try
            {
                List<String> lista = tac.consultarTodasAlunoTurma();
                foreach (String item in lista)
                {
                    cbId.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
        }


        private void btnDesmatricular_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbId.Text == "")
                {
                    MessageBox.Show("Selecione um Id!");
                    return;
                }

                if (tac.desmatricular(Convert.ToInt32(cbId.SelectedItem.ToString())))
                {
                    MessageBox.Show("Aluno desmatriculado com sucesso!");
                    int qtdeAlunos = tac.qtdeAlunosMatriculados(Convert.ToInt32(txtIdTurma.Text));
                    tc.atualizarNumAlunos(Convert.ToInt32(txtIdTurma.Text), qtdeAlunos);
                    atualizarCbId();
                    txtCpfAluno.Text = "";
                    txtIdTurma.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao desmatricular aluno!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao desmatricular: " + ex.Message);
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AlunoTurma at = tac.buscar(Convert.ToInt32(cbId.SelectedItem.ToString()));
                txtCpfAluno.Text = at.getSetCpfAluno;
                txtIdTurma.Text = at.getSetIdTurma.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Modalidade: " + ex.Message);
            }
        }
    }
}
