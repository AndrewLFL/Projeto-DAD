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
    
        private void InitializeComponent()
        {
            this.gbModalidades = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModalidades
            // 
            this.gbModalidades.Controls.Add(this.cbAtivo);
            this.gbModalidades.Controls.Add(this.lblAtivo);
            this.gbModalidades.Controls.Add(this.cbDescricao);
            this.gbModalidades.Controls.Add(this.btnAtualizar);
            this.gbModalidades.Controls.Add(this.txtQtdeAulas);
            this.gbModalidades.Controls.Add(this.txtQtdeAlunos);
            this.gbModalidades.Controls.Add(this.txtPreco);
            this.gbModalidades.Controls.Add(this.lblQtdeAulas);
            this.gbModalidades.Controls.Add(this.lblQtdeAlunos);
            this.gbModalidades.Controls.Add(this.lblPreco);
            this.gbModalidades.Controls.Add(this.lblDescricao);
            this.gbModalidades.Location = new System.Drawing.Point(32, 13);
            this.gbModalidades.Name = "gbModalidades";
            this.gbModalidades.Size = new System.Drawing.Size(354, 317);
            this.gbModalidades.TabIndex = 0;
            this.gbModalidades.TabStop = false;
            this.gbModalidades.Text = "Modalidades";
            // 
            // cbAtivo
            // 
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbAtivo.Location = new System.Drawing.Point(111, 211);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(202, 21);
            this.cbAtivo.TabIndex = 20;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(50, 213);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 19;
            this.lblAtivo.Text = "Ativo:";
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(111, 49);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(202, 21);
            this.cbDescricao.TabIndex = 18;
            this.cbDescricao.SelectedIndexChanged += new System.EventHandler(this.cbDescricao_SelectedIndexChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(44, 256);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(268, 28);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(159, 167);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAulas.TabIndex = 16;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(159, 130);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAlunos.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(111, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(202, 20);
            this.txtPreco.TabIndex = 14;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(44, 170);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(109, 13);
            this.lblQtdeAulas.TabIndex = 12;
            this.lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(44, 133);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(115, 13);
            this.lblQtdeAlunos.TabIndex = 11;
            this.lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(44, 94);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(44, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // FrmAtualizarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 353);
            this.Controls.Add(this.gbModalidades);
            this.Name = "FrmAtualizarModalidade";
            this.Text = "Atualizar Modalidade";
            this.gbModalidades.ResumeLayout(false);
            this.gbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        //#endregion

        private System.Windows.Forms.GroupBox gbModalidades;
        private System.Windows.Forms.ComboBox cbAtivo;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.ComboBox cbDescricao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
    }
}