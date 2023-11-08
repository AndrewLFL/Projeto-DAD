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
        int idTurma = 0;
        String cpfAluno = "";

        public FrmDesmatricularAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
            tc = new TurmaControl();
            tac = new AlunoTurmaControl();
            mc = new ModalidadeControl();

            atualizarDgvTurma();
        }

        private void atualizarDgvTurma()
        {
            try
            {
                dgvTurma.Rows.Clear();
                List<Turma> lista = tc.consultarTodasTurmasAtivasObjeto();
                foreach (Turma turma in lista)
                {
                    dgvTurma.Rows.Add(turma.getSetId, mc.buscarDescricao(turma.getSetModalidade), turma.getSetProfessor, turma.getSetDiaSemana, turma.getSetHorario, turma.getSetNumAlunos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos e turmas: " + ex.Message);
            }
        }


        private void btnDesmatricular_Click(object sender, EventArgs e)
        {

            try
            {
                if (idTurma == 0 || cpfAluno == "")
                {
                    MessageBox.Show("Selecione uma turma e um aluno!");
                    return;
                }
                if (tac.desmatricular(idTurma,cpfAluno))
                {
                    MessageBox.Show("Aluno desmatriculado com sucesso!");
                    int qtdeAlunos = tac.qtdeAlunosMatriculados(idTurma);
                    tc.atualizarNumAlunos(idTurma, qtdeAlunos);
                    atualizarDgvTurma();
                    dgvAlunos.Rows.Clear();
                    idTurma = 0;
                    cpfAluno = "";
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

        private void dgvTurma_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.idTurma = int.Parse(dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgvAlunos.Rows.Clear();
                String idTurma = dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<String> lista = tac.consultarTodosAlunoPorTurma(int.Parse(idTurma));
                foreach (String cpf in lista)
                {
                    Aluno aluno = ac.buscar(cpf);
                    dgvAlunos.Rows.Add(aluno.getSetCpf, aluno.getSetNome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao selecionar uma linha: " + ex.Message);
            }
        }

        private void dgvAlunos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.cpfAluno = dgvAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
