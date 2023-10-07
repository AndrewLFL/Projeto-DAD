using Estudio.control;
using Estudio.view;

namespace Estudio
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
                MessageBox.Show(msg);
                if (msg.Equals("Login realizado como Administrador!") || msg.Equals("Login realizado como Restrito!"))
                {
                    gbValidacao.Visible = false;
                    menuStrip.Enabled = true;
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

        private void mitcadastrarUsu�rio_Click(object sender, EventArgs e)
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
            
        }
    }
}