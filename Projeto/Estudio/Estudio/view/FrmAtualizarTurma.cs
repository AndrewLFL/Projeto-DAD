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
    public partial class FrmAtualizarTurma : Form
    {
        private ModalidadeControl mc;
        private TurmaControl tc;

        public FrmAtualizarTurma()
        {
            InitializeComponent();
            mc = new ModalidadeControl();
            tc = new TurmaControl();
            try
            {
                List<String> modalidades = mc.consultarTodasModalidadesAtivas();
                foreach (String mod in modalidades)
                {
                    cbModalidade.Items.Add(mod);
                }

                List<String> lista = tc.consultarTodasTurmas();
                foreach (String turma in lista)
                {
                    cbId.Items.Add(turma);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar modalidades e turmas: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbId.Text);
                int modalidade = mc.buscar(cbModalidade.SelectedItem.ToString()).getSetId;
                String professor = txtProfessor.Text;
                String diaSemana = txtDiaSemana.Text;
                String horario = txtHorario.Text;
                int numAlunos = int.Parse(txtNumAlunos.Text);
                int ativo = int.Parse(cbAtivo.Text);
                Turma t = new Turma(modalidade,professor,diaSemana,horario,numAlunos,ativo,id);
                if (tc.atualizar(t))
                {
                    MessageBox.Show("Turma atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar turma!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar turma: " + ex.Message);
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Turma t = tc.buscar(int.Parse(cbId.SelectedItem.ToString()));
                txtDiaSemana.Text = t.getSetDiaSemana;
                txtHorario.Text = t.getSetHorario;
                cbModalidade.Text = mc.buscarDescricao(t.getSetModalidade);
                txtProfessor.Text = t.getSetProfessor;
                txtNumAlunos.Text = t.getSetNumAlunos.ToString();
                cbAtivo.Text = t.getSetAtivo.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar Turma: " + ex.Message);
            }
        }
    }
}
