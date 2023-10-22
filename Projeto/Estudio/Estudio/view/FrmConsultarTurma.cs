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
    public partial class FrmConsultarTurma : Form
    {

        ModalidadeControl mc;
        TurmaControl tc;
        public FrmConsultarTurma()
        {
            InitializeComponent();
            mc = new ModalidadeControl();
            tc = new TurmaControl();

            try
            {
                List<String> lista = tc.consultarTodasTurmasAtivas();
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
                Console.WriteLine("Erro ao buscar Turma: " + ex.Message);
            }
        }
    }
}
