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
    public partial class FrmCadastrarUsuario : Form
    {
        private UsuarioControl uc;

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
            uc = new UsuarioControl();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = null;
                if (txtUsername.Equals("") || txtSenha.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                else if (cbbTipo.SelectedIndex==0)
                {
                    u = new Usuario(txtUsername.Text, txtSenha.Text, 1);
                }
                else if(cbbTipo.SelectedIndex == 1)
                {
                    u = new Usuario(txtUsername.Text, txtSenha.Text, 2);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                uc.cadastrar(u);
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch
            (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }   
        }
    }
}
