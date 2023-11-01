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

                AlunoTurma at = tac.buscar(Convert.ToInt32(cbId.SelectedItem.ToString()));

                if (tac.desmatricular(Convert.ToInt32(cbId.SelectedItem.ToString())))
                {
                    MessageBox.Show("Aluno desmatriculado com sucesso!");
                    int qtdeAlunos = tac.qtdeAlunosMatriculados(at.getSetIdTurma);
                    tc.atualizarNumAlunos(at.getSetIdTurma, qtdeAlunos);
                    dgvTurma.Rows.Clear();
                    dgvAluno.Rows.Clear();
                    atualizarCbId();
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
                dgvTurma.Rows.Clear();
                dgvAluno.Rows.Clear();
                AlunoTurma at = tac.buscar(Convert.ToInt32(cbId.SelectedItem.ToString()));
                Turma turma = tc.buscar(at.getSetIdTurma);
                dgvTurma.Rows.Add(turma.getSetId, mc.buscarDescricao(turma.getSetModalidade), turma.getSetProfessor, turma.getSetDiaSemana, turma.getSetHorario, turma.getSetNumAlunos);
                Aluno aluno = ac.buscar(at.getSetCpfAluno);
                dgvAluno.Rows.Add(aluno.getSetCpf, aluno.getSetNome);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Modalidade: " + ex.Message);
            }
        }
    }
}
