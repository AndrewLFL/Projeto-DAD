
namespace Estudio.view
{
    partial class FrmExcluirModalidade
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbModalidades = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(47, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 25);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbModalidades
            // 
            this.gbModalidades.Controls.Add(this.btnExcluir);
            this.gbModalidades.Controls.Add(this.txtDescricao);
            this.gbModalidades.Controls.Add(this.cbId);
            this.gbModalidades.Controls.Add(this.lblId);
            this.gbModalidades.Controls.Add(this.txtQtdeAulas);
            this.gbModalidades.Controls.Add(this.txtQtdeAlunos);
            this.gbModalidades.Controls.Add(this.txtPreco);
            this.gbModalidades.Controls.Add(this.lblQtdeAulas);
            this.gbModalidades.Controls.Add(this.lblQtdeAlunos);
            this.gbModalidades.Controls.Add(this.lblPreco);
            this.gbModalidades.Controls.Add(this.label1);
            this.gbModalidades.Location = new System.Drawing.Point(23, 21);
            this.gbModalidades.Name = "gbModalidades";
            this.gbModalidades.Size = new System.Drawing.Size(354, 280);
            this.gbModalidades.TabIndex = 2;
            this.gbModalidades.TabStop = false;
            this.gbModalidades.Text = "Modalidades";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(111, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(202, 20);
            this.txtDescricao.TabIndex = 23;
            // 
            // cbId
            // 
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(111, 34);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(121, 21);
            this.cbId.TabIndex = 22;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(159, 191);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.ReadOnly = true;
            this.txtQtdeAulas.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAulas.TabIndex = 16;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(159, 154);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.ReadOnly = true;
            this.txtQtdeAlunos.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAlunos.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(111, 116);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(202, 20);
            this.txtPreco.TabIndex = 14;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(44, 194);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(109, 13);
            this.lblQtdeAulas.TabIndex = 12;
            this.lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(44, 157);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(115, 13);
            this.lblQtdeAlunos.TabIndex = 11;
            this.lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(44, 118);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrição:";
            // 
            // FrmExcluirModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 325);
            this.Controls.Add(this.gbModalidades);
            this.Name = "FrmExcluirModalidade";
            this.Text = "Excluir Modalidade";
            this.gbModalidades.ResumeLayout(false);
            this.gbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbModalidades;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label1;
    }
}