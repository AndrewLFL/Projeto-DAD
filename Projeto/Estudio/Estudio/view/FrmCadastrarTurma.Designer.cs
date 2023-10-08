namespace Estudio.view
{
    partial class FrmCadastrarTurma
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
            txtHorario = new TextBox();
            txtDiaSemana = new TextBox();
            txtProfessor = new TextBox();
            txtModalidade = new TextBox();
            btnCadastrar = new Button();
            lblHorario = new Label();
            lblDiaSemana = new Label();
            lblProfessor = new Label();
            lblModalidade = new Label();
            dgvTurma = new DataGridView();
            cdgvModalidade = new DataGridViewTextBoxColumn();
            gbTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurma).BeginInit();
            SuspendLayout();
            // 
            // gbTurma
            // 
            gbTurma.Controls.Add(txtHorario);
            gbTurma.Controls.Add(txtDiaSemana);
            gbTurma.Controls.Add(txtProfessor);
            gbTurma.Controls.Add(txtModalidade);
            gbTurma.Controls.Add(btnCadastrar);
            gbTurma.Controls.Add(lblHorario);
            gbTurma.Controls.Add(lblDiaSemana);
            gbTurma.Controls.Add(lblProfessor);
            gbTurma.Controls.Add(lblModalidade);
            gbTurma.Location = new Point(26, 17);
            gbTurma.Name = "gbTurma";
            gbTurma.Size = new Size(479, 235);
            gbTurma.TabIndex = 0;
            gbTurma.TabStop = false;
            gbTurma.Text = "Turma";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(129, 148);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(327, 23);
            txtHorario.TabIndex = 8;
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(129, 113);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(327, 23);
            txtDiaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(129, 72);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(327, 23);
            txtProfessor.TabIndex = 6;
            // 
            // txtModalidade
            // 
            txtModalidade.Location = new Point(129, 34);
            txtModalidade.Name = "txtModalidade";
            txtModalidade.ReadOnly = true;
            txtModalidade.Size = new Size(327, 23);
            txtModalidade.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(19, 189);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(437, 30);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(19, 151);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(50, 15);
            lblHorario.TabIndex = 3;
            lblHorario.Text = "Horário:";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(19, 116);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(88, 15);
            lblDiaSemana.TabIndex = 2;
            lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Location = new Point(19, 75);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(59, 15);
            lblProfessor.TabIndex = 1;
            lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            lblModalidade.AutoSize = true;
            lblModalidade.Location = new Point(19, 37);
            lblModalidade.Name = "lblModalidade";
            lblModalidade.Size = new Size(73, 15);
            lblModalidade.TabIndex = 0;
            lblModalidade.Text = "Modalidade:";
            // 
            // dgvTurma
            // 
            dgvTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurma.Columns.AddRange(new DataGridViewColumn[] { cdgvModalidade });
            dgvTurma.Location = new Point(26, 258);
            dgvTurma.Name = "dgvTurma";
            dgvTurma.ReadOnly = true;
            dgvTurma.RowTemplate.Height = 25;
            dgvTurma.Size = new Size(479, 249);
            dgvTurma.TabIndex = 1;
            dgvTurma.CellMouseDoubleClick += dgvTurma_CellMouseDoubleClick;
            // 
            // cdgvModalidade
            // 
            cdgvModalidade.HeaderText = "Modalidade";
            cdgvModalidade.Name = "cdgvModalidade";
            cdgvModalidade.ReadOnly = true;
            // 
            // FrmCadastrarTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 519);
            Controls.Add(dgvTurma);
            Controls.Add(gbTurma);
            Name = "FrmCadastrarTurma";
            Text = "Cadastro de Turma";
            gbTurma.ResumeLayout(false);
            gbTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTurma;
        private TextBox txtHorario;
        private TextBox txtDiaSemana;
        private TextBox txtProfessor;
        private TextBox txtModalidade;
        private Button btnCadastrar;
        private Label lblHorario;
        private Label lblDiaSemana;
        private Label lblProfessor;
        private Label lblModalidade;
        private DataGridView dgvTurma;
        private DataGridViewTextBoxColumn cdgvModalidade;
    }
}