
namespace Estudio
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dgvModalidade = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTurma
            // 
            this.gbTurma.Controls.Add(this.txtHora);
            this.gbTurma.Controls.Add(this.txtDiaSemana);
            this.gbTurma.Controls.Add(this.txtProf);
            this.gbTurma.Controls.Add(this.txtModalidade);
            this.gbTurma.Controls.Add(this.lblHora);
            this.gbTurma.Controls.Add(this.lblDiaSemana);
            this.gbTurma.Controls.Add(this.lblProf);
            this.gbTurma.Controls.Add(this.lblModalidade);
            this.gbTurma.Controls.Add(this.btnCadastrar);
            this.gbTurma.Location = new System.Drawing.Point(13, 12);
            this.gbTurma.Name = "gbTurma";
            this.gbTurma.Size = new System.Drawing.Size(413, 227);
            this.gbTurma.TabIndex = 0;
            this.gbTurma.TabStop = false;
            this.gbTurma.Text = "Turma";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 186);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(401, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(25, 35);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 1;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(25, 68);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(54, 13);
            this.lblProf.TabIndex = 2;
            this.lblProf.Text = "Professor:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(25, 100);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 3;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(25, 128);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(114, 28);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(280, 20);
            this.txtModalidade.TabIndex = 5;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(114, 61);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(280, 20);
            this.txtProf.TabIndex = 6;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(114, 93);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(280, 20);
            this.txtDiaSemana.TabIndex = 7;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(114, 121);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(280, 20);
            this.txtHora.TabIndex = 8;
            // 
            // dgvModalidade
            // 
            this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dgvModalidade.Location = new System.Drawing.Point(13, 260);
            this.dgvModalidade.Name = "dgvModalidade";
            this.dgvModalidade.Size = new System.Drawing.Size(413, 295);
            this.dgvModalidade.TabIndex = 1;
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            // 
            // FrmCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 566);
            this.Controls.Add(this.dgvModalidade);
            this.Controls.Add(this.gbTurma);
            this.Name = "FrmCadastrarTurma";
            this.Text = "Cadastro de Turma";
            this.Load += new System.EventHandler(this.FrmCadastrarTurma_Load);
            this.gbTurma.ResumeLayout(false);
            this.gbTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurma;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
    }
}