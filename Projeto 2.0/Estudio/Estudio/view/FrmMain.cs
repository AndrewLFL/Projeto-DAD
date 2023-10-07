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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void mitAluno_Click(object sender, EventArgs e)
        {

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
    }
}