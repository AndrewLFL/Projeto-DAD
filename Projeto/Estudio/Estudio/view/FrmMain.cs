using Estudio.control;
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
    public partial class FrmMain : Form
    {
        private UsuarioControl uc;

        public FrmMain()
        {
            InitializeComponent();
            uc = new UsuarioControl();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUsername.Text;
                String senha = txtSenha.Text;
                String msg = uc.logar(username, senha);
                if (msg.Equals("Login realizado como Administrador!"))
                {
                    this.Text = "Estúdio - Administrador";
                    gbValidacao.Visible = false;
                    menuStrip.Enabled = true;
                    rbAdmin.Visible = false;
                    rbRestrito.Visible = false;
                    lblEscolha.Visible = false;
                }
                else if (msg.Equals("Login realizado como Restrito!"))
                {
                    this.Text = "Estúdio - Restrito";
                    gbValidacao.Visible = false;
                    menuStrip.Enabled = true;
                    mitAtualizarModalidade.Enabled = false;
                    mitAtualizarTurma.Enabled = false;
                    mitCadastrarModalidade.Enabled = false;
                    mitCadastrarTurma.Enabled = false;
                    mitCadastrarUsuario.Enabled = false;
                    mitExcluirModalidade.Enabled = false;
                    mitExcluirTurma.Enabled = false;
                    mitMatricularAluno.Enabled = false;
                    mitDesmatricularAluno.Enabled = false;
                    rbAdmin.Visible = false;
                    rbRestrito.Visible = false;
                    lblEscolha.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
        }

        private void mitSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitcadastrarUsuário_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frmCadastrarUsuario = new FrmCadastrarUsuario();
            frmCadastrarUsuario.MdiParent = this;
            frmCadastrarUsuario.Show();
        }

        private void mitCadastrarAluno_Click(object sender, EventArgs e)
        {
            FrmCadastrarAluno frmCadastrarAluno = new FrmCadastrarAluno();
            frmCadastrarAluno.MdiParent = this;
            frmCadastrarAluno.Show();
        }

        private void mitExcluirAluno_Click(object sender, EventArgs e)
        {
            FrmExcluirAluno frmExcluirAluno = new FrmExcluirAluno();
            frmExcluirAluno.MdiParent = this;
            frmExcluirAluno.Show();
        }

        private void mitAtualizarAluno_Click(object sender, EventArgs e)
        {
            FrmAtualizarAluno frmAtualizarAluno = new FrmAtualizarAluno();
            frmAtualizarAluno.MdiParent = this;
            frmAtualizarAluno.Show();
        }

        private void mitCadastrarModalidade_Click(object sender, EventArgs e)
        {
            FrmCadastrarModalidade frmCadastrarModalidade = new FrmCadastrarModalidade();
            frmCadastrarModalidade.MdiParent = this;
            frmCadastrarModalidade.Show();
        }

        private void mitExcluirModalidade_Click(object sender, EventArgs e)
        {
            FrmExcluirModalidade frmExcluirModalidade = new FrmExcluirModalidade();
            frmExcluirModalidade.MdiParent = this;
            frmExcluirModalidade.Show();
        }

        private void mitAtualizarModalidade_Click(object sender, EventArgs e)
        {
            FrmAtualizarModalidade frmAtualizarModalidade = new FrmAtualizarModalidade();
            frmAtualizarModalidade.MdiParent = this;
            frmAtualizarModalidade.Show();
        }

        private void mitCadastrarTurma_Click(object sender, EventArgs e)
        {
            FrmCadastrarTurma frmCadastrarTurma = new FrmCadastrarTurma();
            frmCadastrarTurma.MdiParent = this;
            frmCadastrarTurma.Show();
        }

        private void mitExcluirTurma_Click(object sender, EventArgs e)
        {
            FrmExcluirTurma frmExcluirTurma = new FrmExcluirTurma();
            frmExcluirTurma.MdiParent = this;
            frmExcluirTurma.Show();
        }

        private void mitCadastrarUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frmCadastrarUsuario = new FrmCadastrarUsuario();
            frmCadastrarUsuario.MdiParent = this;
            frmCadastrarUsuario.Show();
        }

        private void mitAtualizarTurma_Click(object sender, EventArgs e)
        {
            FrmAtualizarTurma frmAtualizarTurma = new FrmAtualizarTurma();
            frmAtualizarTurma.MdiParent = this;
            frmAtualizarTurma.Show();
        }

        private void mitConsultarTurma_Click(object sender, EventArgs e)
        {
            FrmConsultarTurma frmConsultarTurma = new FrmConsultarTurma();
            frmConsultarTurma.MdiParent = this;
            frmConsultarTurma.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAluno frmConsultarAluno = new FrmConsultarAluno();
            frmConsultarAluno.MdiParent = this;
            frmConsultarAluno.Show();
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarModalidade frmConsultarModalidade = new FrmConsultarModalidade();
            frmConsultarModalidade.MdiParent = this;
            frmConsultarModalidade.Show();
        }

        private void mitMatricularAluno_Click(object sender, EventArgs e)
        {
            FrmMatricularAluno frmMatricularAluno = new FrmMatricularAluno();
            frmMatricularAluno.MdiParent = this;
            frmMatricularAluno.Show();
        }

        private void mitDesmatricularAluno_Click(object sender, EventArgs e)
        {
            FrmDesmatricularAluno frmDesmatricularAluno = new FrmDesmatricularAluno();
            frmDesmatricularAluno.MdiParent = this;
            frmDesmatricularAluno.Show();
        }

        private void mitConsultarMatricula_Click(object sender, EventArgs e)
        {
            FrmConsultarMatricula frmConsultarMatricula = new FrmConsultarMatricula();
            frmConsultarMatricula.MdiParent = this;
            frmConsultarMatricula.Show();
        }

        private void rbAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "carla";
            txtSenha.Text = "2343";
        }

        private void rbRestrito_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "mario";
            txtSenha.Text = "1234";
        }

    }

}
