﻿
namespace Estudio
{
    partial class Form8
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
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cbDesc = new System.Windows.Forms.ComboBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbModalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModalidade
            // 
            this.gbModalidade.Controls.Add(this.txtAulas);
            this.gbModalidade.Controls.Add(this.txtAlunos);
            this.gbModalidade.Controls.Add(this.txtPreco);
            this.gbModalidade.Controls.Add(this.cbDesc);
            this.gbModalidade.Controls.Add(this.lblAulas);
            this.gbModalidade.Controls.Add(this.lblAlunos);
            this.gbModalidade.Controls.Add(this.lblPreco);
            this.gbModalidade.Controls.Add(this.lblDesc);
            this.gbModalidade.Controls.Add(this.btnAtualizar);
            this.gbModalidade.Location = new System.Drawing.Point(43, 31);
            this.gbModalidade.Name = "gbModalidade";
            this.gbModalidade.Size = new System.Drawing.Size(618, 297);
            this.gbModalidade.TabIndex = 0;
            this.gbModalidade.TabStop = false;
            this.gbModalidade.Text = "Modalidades";
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(164, 192);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(409, 20);
            this.txtAulas.TabIndex = 8;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(164, 148);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(409, 20);
            this.txtAlunos.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(151, 103);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(422, 20);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbDesc
            // 
            this.cbDesc.FormattingEnabled = true;
            this.cbDesc.Items.AddRange(new object[] {
            ""});
            this.cbDesc.Location = new System.Drawing.Point(151, 52);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(422, 21);
            this.cbDesc.TabIndex = 5;
            this.cbDesc.SelectedIndexChanged += new System.EventHandler(this.cbDesc_SelectedIndexChanged);
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Location = new System.Drawing.Point(60, 195);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(77, 13);
            this.lblAulas.TabIndex = 4;
            this.lblAulas.Text = "Qtde de Aulas:";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(60, 151);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(83, 13);
            this.lblAlunos.TabIndex = 3;
            this.lblAlunos.Text = "Qtde de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(60, 106);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(60, 55);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(63, 233);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(510, 27);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.gbModalidade);
            this.Name = "Form8";
            this.Text = "Consultar Modalidade";
            this.gbModalidade.ResumeLayout(false);
            this.gbModalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModalidade;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox cbDesc;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAtualizar;
    }
}