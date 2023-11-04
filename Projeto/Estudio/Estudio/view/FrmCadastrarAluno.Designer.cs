
namespace Estudio.view
{
    partial class FrmCadastrarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.btnFoto);
            this.gbDados.Controls.Add(this.pictureBox1);
            this.gbDados.Controls.Add(this.btnLimpar);
            this.gbDados.Controls.Add(this.mtxtTel);
            this.gbDados.Controls.Add(this.mtxtCpf);
            this.gbDados.Controls.Add(this.mtxtCep);
            this.gbDados.Controls.Add(this.txtEstado);
            this.gbDados.Controls.Add(this.txtComplemento);
            this.gbDados.Controls.Add(this.txtNum);
            this.gbDados.Controls.Add(this.txtEmail);
            this.gbDados.Controls.Add(this.txtCidade);
            this.gbDados.Controls.Add(this.txtBairro);
            this.gbDados.Controls.Add(this.txtEndereco);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.btnCadastrar);
            this.gbDados.Controls.Add(this.lblEstado);
            this.gbDados.Controls.Add(this.lblComplemento);
            this.gbDados.Controls.Add(this.lblNum);
            this.gbDados.Controls.Add(this.lblEmail);
            this.gbDados.Controls.Add(this.lblCidade);
            this.gbDados.Controls.Add(this.lblTel);
            this.gbDados.Controls.Add(this.lblCep);
            this.gbDados.Controls.Add(this.lblBairro);
            this.gbDados.Controls.Add(this.lblEndereco);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.lblCpf);
            this.gbDados.Location = new System.Drawing.Point(28, 23);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(793, 325);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados Cadastrais";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(459, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(84, 232);
            this.mtxtTel.Mask = "(00) 00000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.ReadOnly = true;
            this.mtxtTel.Size = new System.Drawing.Size(127, 20);
            this.mtxtTel.TabIndex = 22;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(84, 41);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(127, 20);
            this.mtxtCpf.TabIndex = 21;
            this.mtxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCpf_KeyPress);
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(84, 190);
            this.mtxtCep.Mask = "00,000-00";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.ReadOnly = true;
            this.mtxtCep.Size = new System.Drawing.Size(104, 20);
            this.mtxtCep.TabIndex = 20;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(397, 192);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(138, 20);
            this.txtEstado.TabIndex = 19;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(397, 146);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(138, 20);
            this.txtComplemento.TabIndex = 18;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(448, 112);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(86, 20);
            this.txtNum.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(266, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(249, 190);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(86, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(84, 146);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(218, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(84, 112);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(308, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(308, 20);
            this.txtNome.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(28, 279);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(507, 27);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(353, 192);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(317, 149);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 9;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(424, 119);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(20, 13);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "nº:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(223, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(203, 192);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(25, 236);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefone:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(25, 193);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(29, 13);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "Cep:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(25, 150);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(25, 115);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(25, 44);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(26, 13);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "Cpf:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(553, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(553, 279);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(221, 27);
            this.btnFoto.TabIndex = 25;
            this.btnFoto.Text = "Escolher Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // FrmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 367);
            this.Controls.Add(this.gbDados);
            this.Name = "FrmCadastrarAluno";
            this.Text = "Cadastrar Aluno";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}