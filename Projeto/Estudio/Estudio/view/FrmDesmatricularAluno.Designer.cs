namespace Estudio.view
{
    partial class FrmDesmatricularAluno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.gbAlunos = new System.Windows.Forms.GroupBox();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.txtcCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.txtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcNumAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gbAlunos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnDesmatricular);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desmatricular";
            // 
            // cbId
            // 
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(467, 46);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(105, 21);
            this.cbId.TabIndex = 6;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(422, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // btnDesmatricular
            // 
            this.btnDesmatricular.Location = new System.Drawing.Point(377, 311);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(277, 49);
            this.btnDesmatricular.TabIndex = 4;
            this.btnDesmatricular.Text = "Desmatricular";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnDesmatricular_Click);
            // 
            // gbAlunos
            // 
            this.gbAlunos.Controls.Add(this.dgvAluno);
            this.gbAlunos.Location = new System.Drawing.Point(17, 279);
            this.gbAlunos.Name = "gbAlunos";
            this.gbAlunos.Size = new System.Drawing.Size(338, 97);
            this.gbAlunos.TabIndex = 8;
            this.gbAlunos.TabStop = false;
            this.gbAlunos.Text = "Aluno Matriculado";
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcCpf,
            this.txtcNome});
            this.dgvAluno.Location = new System.Drawing.Point(6, 20);
            this.dgvAluno.MultiSelect = false;
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(323, 61);
            this.dgvAluno.TabIndex = 1;
            // 
            // txtcCpf
            // 
            this.txtcCpf.HeaderText = "CPF";
            this.txtcCpf.Name = "txtcCpf";
            this.txtcCpf.ReadOnly = true;
            this.txtcCpf.Width = 120;
            // 
            // txtcNome
            // 
            this.txtcNome.HeaderText = "Nome";
            this.txtcNome.Name = "txtcNome";
            this.txtcNome.ReadOnly = true;
            this.txtcNome.Width = 158;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTurma);
            this.groupBox2.Location = new System.Drawing.Point(17, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 142);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Turma";
            // 
            // dgvTurma
            // 
            this.dgvTurma.AllowUserToAddRows = false;
            this.dgvTurma.AllowUserToDeleteRows = false;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcId,
            this.txtcModalidade,
            this.txtcProfessor,
            this.txtcDiaSemana,
            this.txtcHorario,
            this.txtcNumAlunos});
            this.dgvTurma.Location = new System.Drawing.Point(6, 19);
            this.dgvTurma.MultiSelect = false;
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.ReadOnly = true;
            this.dgvTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurma.Size = new System.Drawing.Size(625, 104);
            this.dgvTurma.TabIndex = 0;
            // 
            // txtcId
            // 
            this.txtcId.HeaderText = "ID";
            this.txtcId.Name = "txtcId";
            this.txtcId.ReadOnly = true;
            this.txtcId.Width = 40;
            // 
            // txtcModalidade
            // 
            this.txtcModalidade.HeaderText = "Modalidade";
            this.txtcModalidade.Name = "txtcModalidade";
            this.txtcModalidade.ReadOnly = true;
            // 
            // txtcProfessor
            // 
            this.txtcProfessor.HeaderText = "Professor";
            this.txtcProfessor.Name = "txtcProfessor";
            this.txtcProfessor.ReadOnly = true;
            // 
            // txtcDiaSemana
            // 
            this.txtcDiaSemana.HeaderText = "Dia da Semana";
            this.txtcDiaSemana.Name = "txtcDiaSemana";
            this.txtcDiaSemana.ReadOnly = true;
            this.txtcDiaSemana.Width = 120;
            // 
            // txtcHorario
            // 
            this.txtcHorario.HeaderText = "Horário";
            this.txtcHorario.Name = "txtcHorario";
            this.txtcHorario.ReadOnly = true;
            // 
            // txtcNumAlunos
            // 
            this.txtcNumAlunos.HeaderText = "Número de Alunos";
            this.txtcNumAlunos.Name = "txtcNumAlunos";
            this.txtcNumAlunos.ReadOnly = true;
            this.txtcNumAlunos.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione um id para desmatricular";
            // 
            // FrmDesmatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDesmatricularAluno";
            this.Text = "FrmDesmatricularAluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesmatricular;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbAlunos;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcNumAlunos;
        private System.Windows.Forms.Label label1;
    }
}