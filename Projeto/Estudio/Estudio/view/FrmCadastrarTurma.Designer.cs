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
            this.gbTurma = new System.Windows.Forms.GroupBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.cdgvModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTurma
            // 
            this.gbTurma.Controls.Add(this.txtHorario);
            this.gbTurma.Controls.Add(this.txtDiaSemana);
            this.gbTurma.Controls.Add(this.txtProfessor);
            this.gbTurma.Controls.Add(this.txtModalidade);
            this.gbTurma.Controls.Add(this.btnCadastrar);
            this.gbTurma.Controls.Add(this.lblHorario);
            this.gbTurma.Controls.Add(this.lblDiaSemana);
            this.gbTurma.Controls.Add(this.lblProfessor);
            this.gbTurma.Controls.Add(this.lblModalidade);
            this.gbTurma.Location = new System.Drawing.Point(22, 15);
            this.gbTurma.Name = "gbTurma";
            this.gbTurma.Size = new System.Drawing.Size(411, 204);
            this.gbTurma.TabIndex = 0;
            this.gbTurma.TabStop = false;
            this.gbTurma.Text = "Turma";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(111, 128);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(281, 20);
            this.txtHorario.TabIndex = 8;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(111, 98);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(281, 20);
            this.txtDiaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(111, 62);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(281, 20);
            this.txtProfessor.TabIndex = 6;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(111, 29);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.ReadOnly = true;
            this.txtModalidade.Size = new System.Drawing.Size(281, 20);
            this.txtModalidade.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 164);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(375, 26);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(16, 131);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(16, 101);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(16, 65);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(16, 32);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdgvModalidade});
            this.dgvTurma.Location = new System.Drawing.Point(22, 224);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.ReadOnly = true;
            this.dgvTurma.RowTemplate.Height = 25;
            this.dgvTurma.Size = new System.Drawing.Size(411, 216);
            this.dgvTurma.TabIndex = 1;
            this.dgvTurma.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTurma_CellMouseDoubleClick);
            // 
            // cdgvModalidade
            // 
            this.cdgvModalidade.HeaderText = "Modalidade";
            this.cdgvModalidade.Name = "cdgvModalidade";
            this.cdgvModalidade.ReadOnly = true;
            // 
            // FrmCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.gbTurma);
            this.Name = "FrmCadastrarTurma";
            this.Text = "Cadastro de Turma";
            this.gbTurma.ResumeLayout(false);
            this.gbTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurma;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdgvModalidade;
    }
}