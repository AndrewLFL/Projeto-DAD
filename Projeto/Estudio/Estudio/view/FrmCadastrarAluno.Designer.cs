﻿namespace Estudio.view
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
            gbDados = new GroupBox();
            mtxtTel = new MaskedTextBox();
            mtxtCpf = new MaskedTextBox();
            mtxtCep = new MaskedTextBox();
            txtEstado = new TextBox();
            txtComplemento = new TextBox();
            txtNum = new TextBox();
            txtEmail = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            lblEstado = new Label();
            lblComplemento = new Label();
            lblNum = new Label();
            lblEmail = new Label();
            lblCidade = new Label();
            lblTel = new Label();
            lblCep = new Label();
            lblBairro = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            gbDados.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Controls.Add(mtxtTel);
            gbDados.Controls.Add(mtxtCpf);
            gbDados.Controls.Add(mtxtCep);
            gbDados.Controls.Add(txtEstado);
            gbDados.Controls.Add(txtComplemento);
            gbDados.Controls.Add(txtNum);
            gbDados.Controls.Add(txtEmail);
            gbDados.Controls.Add(txtCidade);
            gbDados.Controls.Add(txtBairro);
            gbDados.Controls.Add(txtEndereco);
            gbDados.Controls.Add(txtNome);
            gbDados.Controls.Add(btnCadastrar);
            gbDados.Controls.Add(lblEstado);
            gbDados.Controls.Add(lblComplemento);
            gbDados.Controls.Add(lblNum);
            gbDados.Controls.Add(lblEmail);
            gbDados.Controls.Add(lblCidade);
            gbDados.Controls.Add(lblTel);
            gbDados.Controls.Add(lblCep);
            gbDados.Controls.Add(lblBairro);
            gbDados.Controls.Add(lblEndereco);
            gbDados.Controls.Add(lblNome);
            gbDados.Controls.Add(lblCpf);
            gbDados.Location = new Point(33, 27);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(665, 375);
            gbDados.TabIndex = 0;
            gbDados.TabStop = false;
            gbDados.Text = "Dados Cadastrais";
            // 
            // mtxtTel
            // 
            mtxtTel.Location = new Point(98, 268);
            mtxtTel.Mask = "(00) 00000-0000";
            mtxtTel.Name = "mtxtTel";
            mtxtTel.Size = new Size(147, 23);
            mtxtTel.TabIndex = 22;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Location = new Point(98, 47);
            mtxtCpf.Mask = "000,000,000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(147, 23);
            mtxtCpf.TabIndex = 21;
            // 
            // mtxtCep
            // 
            mtxtCep.Location = new Point(98, 219);
            mtxtCep.Mask = "00,000-00";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(121, 23);
            mtxtCep.TabIndex = 20;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(463, 222);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(160, 23);
            txtEstado.TabIndex = 19;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(463, 169);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(160, 23);
            txtComplemento.TabIndex = 18;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(523, 129);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(310, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 23);
            txtEmail.TabIndex = 16;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(290, 219);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(98, 169);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(254, 23);
            txtBairro.TabIndex = 14;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(98, 129);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(359, 23);
            txtEndereco.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(359, 23);
            txtNome.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(38, 322);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(585, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(412, 222);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado:";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(370, 172);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 9;
            lblComplemento.Text = "Complemento:";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(495, 137);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(22, 15);
            lblNum.TabIndex = 8;
            lblNum.Text = "nº:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(260, 271);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "E-mail:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(237, 222);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 6;
            lblCidade.Text = "Cidade:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(38, 271);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(54, 15);
            lblTel.TabIndex = 5;
            lblTel.Text = "Telefone:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(38, 222);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 4;
            lblCep.Text = "Cep:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(38, 172);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(38, 132);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(38, 89);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(38, 50);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(29, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf:";
            // 
            // FrmCadastrarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 424);
            Controls.Add(gbDados);
            Name = "FrmCadastrarAluno";
            Text = "Cadastrar Aluno";
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDados;
        private Label lblEstado;
        private Label lblComplemento;
        private Label lblNum;
        private Label lblEmail;
        private Label lblCidade;
        private Label lblTel;
        private Label lblCep;
        private Label lblBairro;
        private Label lblEndereco;
        private Label lblNome;
        private Label lblCpf;
        private MaskedTextBox mtxtTel;
        private MaskedTextBox mtxtCpf;
        private MaskedTextBox mtxtCep;
        private TextBox txtEstado;
        private TextBox txtComplemento;
        private TextBox txtNum;
        private TextBox txtEmail;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Button btnCadastrar;
    }
}