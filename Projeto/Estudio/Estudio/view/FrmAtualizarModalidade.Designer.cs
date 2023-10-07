namespace Estudio.view
{
    partial class FrmAtualizarModalidade
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
            gbModalidades = new GroupBox();
            cbAtivo = new ComboBox();
            lblAtivo = new Label();
            cbDescricao = new ComboBox();
            btnAtualizar = new Button();
            txtQtdeAulas = new TextBox();
            txtQtdeAlunos = new TextBox();
            txtPreco = new TextBox();
            lblQtdeAulas = new Label();
            lblQtdeAlunos = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            gbModalidades.SuspendLayout();
            SuspendLayout();
            // 
            // gbModalidades
            // 
            gbModalidades.Controls.Add(cbAtivo);
            gbModalidades.Controls.Add(lblAtivo);
            gbModalidades.Controls.Add(cbDescricao);
            gbModalidades.Controls.Add(btnAtualizar);
            gbModalidades.Controls.Add(txtQtdeAulas);
            gbModalidades.Controls.Add(txtQtdeAlunos);
            gbModalidades.Controls.Add(txtPreco);
            gbModalidades.Controls.Add(lblQtdeAulas);
            gbModalidades.Controls.Add(lblQtdeAlunos);
            gbModalidades.Controls.Add(lblPreco);
            gbModalidades.Controls.Add(lblDescricao);
            gbModalidades.Location = new Point(37, 15);
            gbModalidades.Name = "gbModalidades";
            gbModalidades.Size = new Size(413, 366);
            gbModalidades.TabIndex = 0;
            gbModalidades.TabStop = false;
            gbModalidades.Text = "Modalidades";
            // 
            // cbAtivo
            // 
            cbAtivo.FormattingEnabled = true;
            cbAtivo.Items.AddRange(new object[] { "0", "1" });
            cbAtivo.Location = new Point(129, 243);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(235, 23);
            cbAtivo.TabIndex = 20;
            // 
            // lblAtivo
            // 
            lblAtivo.AutoSize = true;
            lblAtivo.Location = new Point(58, 246);
            lblAtivo.Name = "lblAtivo";
            lblAtivo.Size = new Size(38, 15);
            lblAtivo.TabIndex = 19;
            lblAtivo.Text = "Ativo:";
            // 
            // cbDescricao
            // 
            cbDescricao.FormattingEnabled = true;
            cbDescricao.Location = new Point(129, 56);
            cbDescricao.Name = "cbDescricao";
            cbDescricao.Size = new Size(235, 23);
            cbDescricao.TabIndex = 18;
            cbDescricao.SelectedIndexChanged += cbDescricao_SelectedIndexChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(51, 295);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(313, 32);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtQtdeAulas
            // 
            txtQtdeAulas.Location = new Point(185, 193);
            txtQtdeAulas.Name = "txtQtdeAulas";
            txtQtdeAulas.Size = new Size(179, 23);
            txtQtdeAulas.TabIndex = 16;
            // 
            // txtQtdeAlunos
            // 
            txtQtdeAlunos.Location = new Point(185, 150);
            txtQtdeAlunos.Name = "txtQtdeAlunos";
            txtQtdeAlunos.Size = new Size(179, 23);
            txtQtdeAlunos.TabIndex = 15;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(129, 106);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(235, 23);
            txtPreco.TabIndex = 14;
            // 
            // lblQtdeAulas
            // 
            lblQtdeAulas.AutoSize = true;
            lblQtdeAulas.Location = new Point(51, 196);
            lblQtdeAulas.Name = "lblQtdeAulas";
            lblQtdeAulas.Size = new Size(120, 15);
            lblQtdeAulas.TabIndex = 12;
            lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            lblQtdeAlunos.AutoSize = true;
            lblQtdeAlunos.Location = new Point(51, 153);
            lblQtdeAlunos.Name = "lblQtdeAlunos";
            lblQtdeAlunos.Size = new Size(128, 15);
            lblQtdeAlunos.TabIndex = 11;
            lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(51, 109);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(51, 59);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 9;
            lblDescricao.Text = "Descrição:";
            // 
            // FrmAtualizarModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 407);
            Controls.Add(gbModalidades);
            Name = "FrmAtualizarModalidade";
            Text = "Atualizar Modalidade";
            gbModalidades.ResumeLayout(false);
            gbModalidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModalidades;
        private ComboBox cbAtivo;
        private Label lblAtivo;
        private ComboBox cbDescricao;
        private Button btnAtualizar;
        private TextBox txtQtdeAulas;
        private TextBox txtQtdeAlunos;
        private TextBox txtPreco;
        private Label lblQtdeAulas;
        private Label lblQtdeAlunos;
        private Label lblPreco;
        private Label lblDescricao;
    }
}