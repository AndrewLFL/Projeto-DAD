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
    public partial class FrmExcluirAluno : Form
    {
        public FrmExcluirAluno()
        {
            InitializeComponent();
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            AlunoControl ac = new AlunoControl();
            if (e.KeyChar == 13)
            {
                if (ac.consultar(mtxtCpf.Text))
                {
                    if (ac.excluir(mtxtCpf.Text))
                    {
                        MessageBox.Show("Aluno excluído!");
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!");
                }
            }
        }
    }
}
