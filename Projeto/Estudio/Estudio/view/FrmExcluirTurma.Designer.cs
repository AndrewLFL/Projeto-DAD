namespace Estudio.view
{
    partial class FrmExcluirTurma
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
            this.gbTurma = new System.Windows.Forms.GroupBox();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.gbTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTurma
            // 
            this.gbTurma.Controls.Add(this.txtNumAlunos);
            this.gbTurma.Controls.Add(this.label1);
            this.gbTurma.Controls.Add(this.cbId);
            this.gbTurma.Controls.Add(this.lblId);
            this.gbTurma.Controls.Add(this.txtModalidade);
            this.gbTurma.Controls.Add(this.txtHorario);
            this.gbTurma.Controls.Add(this.txtDiaSemana);
            this.gbTurma.Controls.Add(this.txtProfessor);
            this.gbTurma.Controls.Add(this.btnExcluir);
            this.gbTurma.Controls.Add(this.lblHorario);
            this.gbTurma.Controls.Add(this.lblDiaSemana);
            this.gbTurma.Controls.Add(this.lblProfessor);
            this.gbTurma.Controls.Add(this.lblModalidade);
            this.gbTurma.Location = new System.Drawing.Point(27, 23);
            this.gbTurma.Name = "gbTurma";
            this.gbTurma.Size = new System.Drawing.Size(411, 269);
            this.gbTurma.TabIndex = 1;
            this.gbTurma.TabStop = false;
            this.gbTurma.Text = "Turma";
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Location = new System.Drawing.Point(123, 188);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.ReadOnly = true;
            this.txtNumAlunos.Size = new System.Drawing.Size(104, 20);
            this.txtNumAlunos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número de Alunos:";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(123, 29);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(104, 21);
            this.cbId.TabIndex = 11;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID:";
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(123, 58);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.ReadOnly = true;
            this.txtModalidade.Size = new System.Drawing.Size(268, 20);
            this.txtModalidade.TabIndex = 9;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(123, 156);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(268, 20);
            this.txtHorario.TabIndex = 8;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(123, 126);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.ReadOnly = true;
            this.txtDiaSemana.Size = new System.Drawing.Size(268, 20);
            this.txtDiaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(123, 90);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(268, 20);
            this.txtProfessor.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(16, 226);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(375, 26);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(16, 159);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(16, 128);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(16, 93);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(16, 60);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // FrmExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 309);
            this.Controls.Add(this.gbTurma);
            this.Name = "FrmExcluirTurma";
            this.Text = "Excluir Turma";
            this.gbTurma.ResumeLayout(false);
            this.gbTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurma;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.Label label1;
    }
}