
namespace Estudio.view
{
    partial class FrmAtualizarTurma
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
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblNumAlunos = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.gbTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTurma
            // 
            this.gbTurma.Controls.Add(this.txtNumAlunos);
            this.gbTurma.Controls.Add(this.cbAtivo);
            this.gbTurma.Controls.Add(this.lblAtivo);
            this.gbTurma.Controls.Add(this.lblNumAlunos);
            this.gbTurma.Controls.Add(this.cbId);
            this.gbTurma.Controls.Add(this.lblId);
            this.gbTurma.Controls.Add(this.cbModalidade);
            this.gbTurma.Controls.Add(this.txtHorario);
            this.gbTurma.Controls.Add(this.txtDiaSemana);
            this.gbTurma.Controls.Add(this.txtProfessor);
            this.gbTurma.Controls.Add(this.btnAtualizar);
            this.gbTurma.Controls.Add(this.lblHorario);
            this.gbTurma.Controls.Add(this.lblDiaSemana);
            this.gbTurma.Controls.Add(this.lblProfessor);
            this.gbTurma.Controls.Add(this.lblModalidade);
            this.gbTurma.Location = new System.Drawing.Point(12, 12);
            this.gbTurma.Name = "gbTurma";
            this.gbTurma.Size = new System.Drawing.Size(309, 309);
            this.gbTurma.TabIndex = 1;
            this.gbTurma.TabStop = false;
            this.gbTurma.Text = "Turma";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(113, 161);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(169, 20);
            this.txtHorario.TabIndex = 8;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(113, 130);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(169, 20);
            this.txtDiaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(113, 95);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(169, 20);
            this.txtProfessor.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(22, 267);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(260, 26);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(18, 164);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(18, 133);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(18, 99);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(18, 65);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // cbModalidade
            // 
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(113, 62);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(169, 21);
            this.cbModalidade.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id:";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(113, 30);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(104, 21);
            this.cbId.TabIndex = 11;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblNumAlunos
            // 
            this.lblNumAlunos.AutoSize = true;
            this.lblNumAlunos.Location = new System.Drawing.Point(19, 196);
            this.lblNumAlunos.Name = "lblNumAlunos";
            this.lblNumAlunos.Size = new System.Drawing.Size(97, 13);
            this.lblNumAlunos.TabIndex = 12;
            this.lblNumAlunos.Text = "Número de Alunos:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(18, 231);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 13;
            this.lblAtivo.Text = "Ativo:";
            // 
            // cbAtivo
            // 
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbAtivo.Location = new System.Drawing.Point(113, 229);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(104, 21);
            this.cbAtivo.TabIndex = 14;
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Location = new System.Drawing.Point(113, 193);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.ReadOnly = true;
            this.txtNumAlunos.Size = new System.Drawing.Size(169, 20);
            this.txtNumAlunos.TabIndex = 15;
            // 
            // FrmAtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 336);
            this.Controls.Add(this.gbTurma);
            this.Name = "FrmAtualizarTurma";
            this.Text = "Atualizar Turma";
            this.gbTurma.ResumeLayout(false);
            this.gbTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurma;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.ComboBox cbAtivo;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblNumAlunos;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbModalidade;
    }
}