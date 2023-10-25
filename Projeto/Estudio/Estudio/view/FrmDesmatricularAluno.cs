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
                List<String> lista = ac.consultarTodosAlunos();
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
                    MessageBox.Show("Aluno matriculado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao matricular aluno!");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Matricular: " + ex.Message);
            }
        }
    }
}
