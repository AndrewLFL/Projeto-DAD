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
    public partial class FrmExcluirTurma : Form
    {
        private TurmaControl tc;

        public FrmExcluirTurma()
        {
            InitializeComponent();
            tc = new TurmaControl();
            try
            {
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
                txtModalidade.Text = t.getSetModalidade.ToString();
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
