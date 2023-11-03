using Estudio.control;
using Estudio.model;
using System;
using System.Collections;
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
    public partial class FrmExcluirTurma : Form
    {
        private TurmaControl tc;
        private AlunoTurmaControl atc;
        private ModalidadeControl mc;

        public FrmExcluirTurma()
        {
            InitializeComponent();
            tc = new TurmaControl();
            atc = new AlunoTurmaControl();
            mc = new ModalidadeControl();
            atualizarCbId();
        }

        private void atualizarCbId()
        {
            try
            {
                cbId.Items.Clear();
                List<String> lista = tc.consultarTodasTurmasAtivas();
                foreach (String turma in lista)
                {
                    cbId.Items.Add(turma);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao listar turmas");
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbId.Text);
                if (tc.excluir(id))
                {
                    MessageBox.Show("Turma excluída com sucesso!");
                    if (atc.excluirMatriculasPorTurma(id))
                    {
                        int qtdeAlunos = atc.qtdeAlunosMatriculados(id);
                        tc.atualizarNumAlunos(id, qtdeAlunos);
                    }
                    else
                    {
                        MessageBox.Show("Houve um problema ao excluir as matriculas relacionadas a esse aluno!");
                    }
                    txtDiaSemana.Text = "";
                    txtHorario.Text = "";
                    txtModalidade.Text = "";
                    txtProfessor.Text = "";
                    txtNumAlunos.Text = "";
                    atualizarCbId();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir turma!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir turma!");
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Turma t = tc.buscar(int.Parse(cbId.SelectedItem.ToString()));
                txtDiaSemana.Text = t.getSetDiaSemana;
                txtHorario.Text = t.getSetHorario;
                txtModalidade.Text = mc.buscarDescricao(t.getSetModalidade);
                txtProfessor.Text = t.getSetProfessor;
                txtNumAlunos.Text = t.getSetNumAlunos.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Modalidade: " + ex.Message);
            }

        }
    }
}
