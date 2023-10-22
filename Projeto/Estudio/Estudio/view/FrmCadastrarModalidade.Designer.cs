
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
            this.gbModalidade = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbModalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModalidade
            // 
            this.gbModalidade.Controls.Add(this.btnCadastrar);
            this.gbModalidade.Controls.Add(this.txtQtdeAulas);
            this.gbModalidade.Controls.Add(this.txtQtdeAlunos);
            this.gbModalidade.Controls.Add(this.txtPreco);
            this.gbModalidade.Controls.Add(this.txtDescricao);
            this.gbModalidade.Controls.Add(this.lblQtdeAulas);
            this.gbModalidade.Controls.Add(this.lblQtdeAlunos);
            this.gbModalidade.Controls.Add(this.lblPreco);
            this.gbModalidade.Controls.Add(this.lblDescricao);
            this.gbModalidade.Location = new System.Drawing.Point(25, 18);
            this.gbModalidade.Name = "gbModalidade";
            this.gbModalidade.Size = new System.Drawing.Size(320, 276);
            this.gbModalidade.TabIndex = 0;
            this.gbModalidade.TabStop = false;
            this.gbModalidade.Text = "Modalidades";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(33, 231);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(268, 28);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(147, 187);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAulas.TabIndex = 7;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(147, 140);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAlunos.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(99, 96);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(202, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(99, 53);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(202, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(33, 190);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(109, 13);
            this.lblQtdeAulas.TabIndex = 3;
            this.lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(33, 143);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(115, 13);
            this.lblQtdeAlunos.TabIndex = 2;
            this.lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(33, 99);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(33, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // FrmCadastrarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 328);
            this.Controls.Add(this.gbModalidade);
            this.Name = "FrmCadastrarModalidade";
            this.Text = "Cadastro de Modalidades";
            this.gbModalidade.ResumeLayout(false);
            this.gbModalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModalidade;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}