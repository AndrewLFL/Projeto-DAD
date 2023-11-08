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
    public partial class FrmMatricularAluno : Form
    {
        AlunoControl ac;
        TurmaControl tc;
        AlunoTurmaControl tac;
        ModalidadeControl mc;
        int idTurma;
        String cpfAluno;

        public FrmMatricularAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
            tc = new TurmaControl();
            tac = new AlunoTurmaControl();
            mc = new ModalidadeControl();

            atualizarDgvTurma();
            atualizarDgvAluno();
        }

        private void atualizarDgvTurma()
        {
            try
            {
                dgvTurma.Rows.Clear();
                List<Turma> lista = tc.consultarTodasTurmasAtivasObjeto();
                int i = 0;
                foreach (Turma turma in lista)
                {
                    dgvTurma.Rows.Add(turma.getSetId, mc.buscarDescricao(turma.getSetModalidade), turma.getSetProfessor, turma.getSetDiaSemana, turma.getSetHorario, turma.getSetNumAlunos);
                    int limAlunos = mc.buscar(turma.getSetModalidade).getSetQtdeAlunos;
                    int qtdeAlunos = tac.qtdeAlunosMatriculados(turma.getSetId);
                    if (qtdeAlunos == limAlunos)
                    {
                        dgvTurma.Rows[i].ReadOnly = true;
                        dgvTurma.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dgvTurma.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;

                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos e turmas: " + ex.Message);
            }
        }

        private void atualizarDgvAluno()
        {
            try
            {
                dgvAlunos.Rows.Clear();
                List<Aluno> lista = ac.consultarTodosAlunosAtivosObjeto();
                foreach (Aluno aluno in lista)
                {
                    dgvAlunos.Rows.Add(aluno.getSetCpf,aluno.getSetNome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos e turmas: " + ex.Message);
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cpfAluno == null || idTurma == 0)
                {
                    MessageBox.Show("Selecione uma Turma e um Aluno!");
                    return;
                }

                int limAlunos = mc.buscar(tc.buscar(idTurma).getSetModalidade).getSetQtdeAlunos;
                int qtdeAlunos = tac.qtdeAlunosMatriculados(idTurma);
                if(qtdeAlunos+1 <= limAlunos)
                {
                    if (!tac.validar(idTurma , cpfAluno))
                    {
                        AlunoTurma ta = new AlunoTurma(cpfAluno,idTurma);
                        if (tac.matricular(ta))
                        {
                            tc.atualizarNumAlunos(idTurma, qtdeAlunos+1);
                            atualizarDgvTurma();
                            MessageBox.Show("Aluno matriculado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao matricular aluno!");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Esse aluno já está matriculado nessa turma!");
                    }
                }
                else
                {
                    MessageBox.Show("O limite de alunos para essa turma já foi alcançado!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Matricular: " + ex.Message);
            }
        }

        private void dgvTurma_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                idTurma = int.Parse(dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                
            }
        }

        private void dgvAlunos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                cpfAluno = dgvAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
