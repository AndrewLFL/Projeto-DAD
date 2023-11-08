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
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.gbAlunos = new System.Windows.Forms.GroupBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            this.gbAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbAlunos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDesmatricular);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desmatricular";
            // 
            // btnDesmatricular
            // 
            this.btnDesmatricular.Location = new System.Drawing.Point(33, 543);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(974, 49);
            this.btnDesmatricular.TabIndex = 4;
            this.btnDesmatricular.Text = "Desmatricular";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnDesmatricular_Click);
            // 
            // gbAlunos
            // 
            this.gbAlunos.Controls.Add(this.dgvAlunos);
            this.gbAlunos.Location = new System.Drawing.Point(673, 27);
            this.gbAlunos.Name = "gbAlunos";
            this.gbAlunos.Size = new System.Drawing.Size(334, 510);
            this.gbAlunos.TabIndex = 6;
            this.gbAlunos.TabStop = false;
            this.gbAlunos.Text = "Alunos Matriculados";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcCpf,
            this.txtcNome});
            this.dgvAlunos.Location = new System.Drawing.Point(6, 19);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(322, 487);
            this.dgvAlunos.TabIndex = 1;
            this.dgvAlunos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlunos_CellMouseClick);
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
            this.groupBox2.Location = new System.Drawing.Point(33, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 510);
            this.groupBox2.TabIndex = 5;
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
            this.dgvTurma.Location = new System.Drawing.Point(6, 17);
            this.dgvTurma.MultiSelect = false;
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.ReadOnly = true;
            this.dgvTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurma.Size = new System.Drawing.Size(625, 487);
            this.dgvTurma.TabIndex = 0;
            this.dgvTurma.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTurma_CellMouseClick);
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
            // FrmDesmatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 636);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDesmatricularAluno";
            this.Text = "FrmDesmatricularAluno";
            this.groupBox1.ResumeLayout(false);
            this.gbAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesmatricular;
        private System.Windows.Forms.GroupBox gbAlunos;
        private System.Windows.Forms.DataGridView dgvAlunos;
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
    }
}