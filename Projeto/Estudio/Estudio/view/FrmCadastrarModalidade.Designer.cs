namespace Estudio.view
{
    partial class FrmCadastrarModalidade
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
            gbModalidade = new GroupBox();
            lblDescricao = new Label();
            lblPreco = new Label();
            lblQtdeAlunos = new Label();
            lblQtdeAulas = new Label();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtQtdeAlunos = new TextBox();
            txtQtdeAulas = new TextBox();
            btnCadastrar = new Button();
            gbModalidade.SuspendLayout();
            SuspendLayout();
            // 
            // gbModalidade
            // 
            gbModalidade.Controls.Add(btnCadastrar);
            gbModalidade.Controls.Add(txtQtdeAulas);
            gbModalidade.Controls.Add(txtQtdeAlunos);
            gbModalidade.Controls.Add(txtPreco);
            gbModalidade.Controls.Add(txtDescricao);
            gbModalidade.Controls.Add(lblQtdeAulas);
            gbModalidade.Controls.Add(lblQtdeAlunos);
            gbModalidade.Controls.Add(lblPreco);
            gbModalidade.Controls.Add(lblDescricao);
            gbModalidade.Location = new Point(29, 21);
            gbModalidade.Name = "gbModalidade";
            gbModalidade.Size = new Size(373, 318);
            gbModalidade.TabIndex = 0;
            gbModalidade.TabStop = false;
            gbModalidade.Text = "Modalidades";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(38, 62);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(38, 114);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço:";
            // 
            // lblQtdeAlunos
            // 
            lblQtdeAlunos.AutoSize = true;
            lblQtdeAlunos.Location = new Point(38, 165);
            lblQtdeAlunos.Name = "lblQtdeAlunos";
            lblQtdeAlunos.Size = new Size(128, 15);
            lblQtdeAlunos.TabIndex = 2;
            lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblQtdeAulas
            // 
            lblQtdeAulas.AutoSize = true;
            lblQtdeAulas.Location = new Point(38, 219);
            lblQtdeAulas.Name = "lblQtdeAulas";
            lblQtdeAulas.Size = new Size(120, 15);
            lblQtdeAulas.TabIndex = 3;
            lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(116, 61);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(235, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(116, 111);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(235, 23);
            txtPreco.TabIndex = 5;
            // 
            // txtQtdeAlunos
            // 
            txtQtdeAlunos.Location = new Point(172, 162);
            txtQtdeAlunos.Name = "txtQtdeAlunos";
            txtQtdeAlunos.Size = new Size(179, 23);
            txtQtdeAlunos.TabIndex = 6;
            // 
            // txtQtdeAulas
            // 
            txtQtdeAulas.Location = new Point(172, 216);
            txtQtdeAulas.Name = "txtQtdeAulas";
            txtQtdeAulas.Size = new Size(179, 23);
            txtQtdeAulas.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(38, 267);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(313, 32);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmCadastrarModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 378);
            Controls.Add(gbModalidade);
            Name = "FrmCadastrarModalidade";
            Text = "Cadastro de Modalidades";
            gbModalidade.ResumeLayout(false);
            gbModalidade.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModalidade;
        private Label lblQtdeAulas;
        private Label lblQtdeAlunos;
        private Label lblPreco;
        private Label lblDescricao;
        private Button btnCadastrar;
        private TextBox txtQtdeAulas;
        private TextBox txtQtdeAlunos;
        private TextBox txtPreco;
        private TextBox txtDescricao;
    }
}