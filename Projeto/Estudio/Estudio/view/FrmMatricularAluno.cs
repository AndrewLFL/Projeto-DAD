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

        public FrmMatricularAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
            tc = new TurmaControl();
            tac = new AlunoTurmaControl();
            mc = new ModalidadeControl();

            atualizarCbTurma();
            atualizarCbAluno();
        }

        public void atualizarCbTurma()
        {
            cbIdTurma.Items.Clear();
            try
            {
                List<String> lista = tc.consultarTodasTurmasAtivas();
                foreach (String item in lista)
                {
                    cbIdTurma.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
        }

        public void atualizarCbAluno()
        {
            cbCpfAluno.Items.Clear();
            try
            {
                List<String> lista = ac.consultarTodosAlunos();
                foreach (String item in lista)
                {
                    cbCpfAluno.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCpfAluno.Text == "" || cbIdTurma.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                int limAlunos = mc.buscar(tc.buscar(Convert.ToInt32(cbIdTurma.SelectedItem.ToString())).getSetModalidade).getSetQtdeAlunos;
                int qtdeAlunos = tac.qtdeAlunosMatriculados(Convert.ToInt32(cbIdTurma.SelectedItem.ToString()));
                if(qtdeAlunos+1 <= limAlunos)
                {
                    AlunoTurma ta = new AlunoTurma(cbCpfAluno.SelectedItem.ToString(),Convert.ToInt32(cbIdTurma.SelectedItem.ToString()));
                    if (tac.matricular(ta))
                    {
                        tc.atualizarNumAlunos(Convert.ToInt32(cbIdTurma.SelectedItem.ToString()), qtdeAlunos+1);
                        MessageBox.Show("Aluno matriculado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao matricular aluno!");
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
    }
}
