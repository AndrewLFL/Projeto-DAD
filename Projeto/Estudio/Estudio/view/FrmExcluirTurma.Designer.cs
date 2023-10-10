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
            gbTurma = new GroupBox();
            txtNumAlunos = new TextBox();
            label1 = new Label();
            cbId = new ComboBox();
            lblId = new Label();
            txtModalidade = new TextBox();
            txtHorario = new TextBox();
            txtDiaSemana = new TextBox();
            txtProfessor = new TextBox();
            btnExcluir = new Button();
            lblHorario = new Label();
            lblDiaSemana = new Label();
            lblProfessor = new Label();
            lblModalidade = new Label();
            gbTurma.SuspendLayout();
            SuspendLayout();
            // 
            // gbTurma
            // 
            gbTurma.Controls.Add(txtNumAlunos);
            gbTurma.Controls.Add(label1);
            gbTurma.Controls.Add(cbId);
            gbTurma.Controls.Add(lblId);
            gbTurma.Controls.Add(txtModalidade);
            gbTurma.Controls.Add(txtHorario);
            gbTurma.Controls.Add(txtDiaSemana);
            gbTurma.Controls.Add(txtProfessor);
            gbTurma.Controls.Add(btnExcluir);
            gbTurma.Controls.Add(lblHorario);
            gbTurma.Controls.Add(lblDiaSemana);
            gbTurma.Controls.Add(lblProfessor);
            gbTurma.Controls.Add(lblModalidade);
            gbTurma.Location = new Point(32, 26);
            gbTurma.Name = "gbTurma";
            gbTurma.Size = new Size(479, 310);
            gbTurma.TabIndex = 1;
            gbTurma.TabStop = false;
            gbTurma.Text = "Turma";
            // 
            // txtNumAlunos
            // 
            txtNumAlunos.Location = new Point(144, 217);
            txtNumAlunos.Name = "txtNumAlunos";
            txtNumAlunos.ReadOnly = true;
            txtNumAlunos.Size = new Size(121, 23);
            txtNumAlunos.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 220);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 12;
            label1.Text = "Número de Alunos:";
            // 
            // cbId
            // 
            cbId.FormattingEnabled = true;
            cbId.Location = new Point(144, 34);
            cbId.Name = "cbId";
            cbId.Size = new Size(121, 23);
            cbId.TabIndex = 11;
            cbId.SelectedIndexChanged += cbId_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 10;
            lblId.Text = "ID:";
            // 
            // txtModalidade
            // 
            txtModalidade.Location = new Point(144, 67);
            txtModalidade.Name = "txtModalidade";
            txtModalidade.ReadOnly = true;
            txtModalidade.Size = new Size(312, 23);
            txtModalidade.TabIndex = 9;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(144, 180);
            txtHorario.Name = "txtHorario";
            txtHorario.ReadOnly = true;
            txtHorario.Size = new Size(312, 23);
            txtHorario.TabIndex = 8;
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(144, 145);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.ReadOnly = true;
            txtDiaSemana.Size = new Size(312, 23);
            txtDiaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(144, 104);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.ReadOnly = true;
            txtProfessor.Size = new Size(312, 23);
            txtProfessor.TabIndex = 6;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(19, 261);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(437, 30);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(19, 183);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(50, 15);
            lblHorario.TabIndex = 3;
            lblHorario.Text = "Horário:";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(19, 148);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(88, 15);
            lblDiaSemana.TabIndex = 2;
            lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Location = new Point(19, 107);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(59, 15);
            lblProfessor.TabIndex = 1;
            lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            lblModalidade.AutoSize = true;
            lblModalidade.Location = new Point(19, 69);
            lblModalidade.Name = "lblModalidade";
            lblModalidade.Size = new Size(73, 15);
            lblModalidade.TabIndex = 0;
            lblModalidade.Text = "Modalidade:";
            // 
            // FrmExcluirTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 357);
            Controls.Add(gbTurma);
            Name = "FrmExcluirTurma";
            Text = "Excluir Turma";
            gbTurma.ResumeLayout(false);
            gbTurma.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTurma;
        private TextBox txtHorario;
        private TextBox txtDiaSemana;
        private TextBox txtProfessor;
        private Button btnExcluir;
        private Label lblHorario;
        private Label lblDiaSemana;
        private Label lblProfessor;
        private Label lblModalidade;
        private Label lblId;
        private TextBox txtModalidade;
        private ComboBox cbId;
        private TextBox txtNumAlunos;
        private Label label1;
    }
}