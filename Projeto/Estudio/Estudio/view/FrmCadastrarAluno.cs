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
    public partial class FrmCadastrarAluno : Form
    {
        AlunoControl ac;

        public FrmCadastrarAluno()
        {
            InitializeComponent();
            ac = new AlunoControl();
        }

        public bool verificaCPF(string CPF)
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro original
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //Lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaCPF(mtxtCpf.Text))
                {
                    if (mtxtCpf.Text == "" || txtNome.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtComplemento.Text == "" || mtxtCep.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || mtxtTel.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos");
                        return;
                    }

                    byte[] foto = ConverterFotoParaByteArray();

                    String cpf = mtxtCpf.Text;
                    String nome = txtNome.Text;
                    String endereco = txtEndereco.Text;
                    String numero = txtNum.Text;
                    String bairro = txtBairro.Text;
                    String complemento = txtComplemento.Text;
                    String cep = mtxtCep.Text;
                    String cidade = txtCidade.Text;
                    String estado = txtEstado.Text;
                    String tel = mtxtTel.Text;
                    String email = txtEmail.Text;
                    Aluno al = new Aluno(cpf, nome, endereco, numero, bairro, complemento, cep, cidade, estado, tel, email, foto);
                    if (ac.cadastrar(al))
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não pode ser realizado");
                    }
                }
                else
                {
                    MessageBox.Show("Insira um cpf válido!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar aluno: " + ex.Message);
            }
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (verificaCPF(mtxtCpf.Text))
                {
                    if (ac.consultar(mtxtCpf.Text))
                    {
                        MessageBox.Show("Esse cpf já está sendo usado!");
                    }
                    else
                    {
                        mtxtCpf.ReadOnly = true;
                        txtBairro.ReadOnly = false;
                        txtCidade.ReadOnly = false;
                        txtComplemento.ReadOnly = false;
                        txtEmail.ReadOnly = false;
                        txtEndereco.ReadOnly = false;
                        txtEstado.ReadOnly = false;
                        txtNome.ReadOnly = false;
                        txtNum.ReadOnly = false;
                        mtxtCep.ReadOnly = false;
                        mtxtTel.ReadOnly = false;
                    }
                }
                else
                {
                    MessageBox.Show("Insira um cpf válido!");
                    mtxtCpf.ReadOnly = false;
                    txtEmail.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtComplemento.ReadOnly = true;
                    txtEndereco.ReadOnly = true;
                    txtEstado.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtNum.ReadOnly = true;
                    mtxtCep.ReadOnly = true;
                    mtxtTel.ReadOnly = true;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtxtCpf.ReadOnly = false;
            txtEmail.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtEstado.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtNum.ReadOnly = true;
            mtxtCep.ReadOnly = true;
            mtxtTel.ReadOnly = true;
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNum.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            mtxtCep.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            mtxtTel.Text = "";
            txtEmail.Text = "";
            mtxtCpf.Text = "";
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }//catch
            }//if
            dialog.Dispose();
        }
    }
}
