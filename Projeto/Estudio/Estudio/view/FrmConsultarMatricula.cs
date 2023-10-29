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
    public partial class FrmConsultarMatricula : Form
    {
        TurmaControl tc;
        AlunoTurmaControl atc;  
        ModalidadeControl mc;
        AlunoControl ac;

        public FrmConsultarMatricula()
        {
            InitializeComponent();
            tc = new TurmaControl();
            atc = new AlunoTurmaControl();
            mc = new ModalidadeControl();
            ac = new AlunoControl();
            atualizarDgvTurma();
        }

        private void atualizarDgvTurma()
        {
            try
            {

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

        private void dgvTurma_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvAlunos.Rows.Clear();
                String idTurma = dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<String> lista = atc.consultarTodosAlunoPorTurma(int.Parse(idTurma));
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
    }
}
