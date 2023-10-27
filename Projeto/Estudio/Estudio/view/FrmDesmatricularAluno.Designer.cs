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
            this.txtIdTurma = new System.Windows.Forms.TextBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.lblIdTurma = new System.Windows.Forms.Label();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdTurma);
            this.groupBox1.Controls.Add(this.txtCpfAluno);
            this.groupBox1.Controls.Add(this.cbId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnDesmatricular);
            this.groupBox1.Controls.Add(this.lblIdTurma);
            this.groupBox1.Controls.Add(this.lblCpfAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desmatricular";
            // 
            // txtIdTurma
            // 
            this.txtIdTurma.Location = new System.Drawing.Point(122, 136);
            this.txtIdTurma.Name = "txtIdTurma";
            this.txtIdTurma.ReadOnly = true;
            this.txtIdTurma.Size = new System.Drawing.Size(204, 20);
            this.txtIdTurma.TabIndex = 8;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(122, 89);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.ReadOnly = true;
            this.txtCpfAluno.Size = new System.Drawing.Size(204, 20);
            this.txtCpfAluno.TabIndex = 7;
            // 
            // cbId
            // 
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(122, 46);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(105, 21);
            this.cbId.TabIndex = 6;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(29, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // btnDesmatricular
            // 
            this.btnDesmatricular.Location = new System.Drawing.Point(32, 185);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(294, 23);
            this.btnDesmatricular.TabIndex = 4;
            this.btnDesmatricular.Text = "Desmatricular";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnDesmatricular_Click);
            // 
            // lblIdTurma
            // 
            this.lblIdTurma.AutoSize = true;
            this.lblIdTurma.Location = new System.Drawing.Point(29, 139);
            this.lblIdTurma.Name = "lblIdTurma";
            this.lblIdTurma.Size = new System.Drawing.Size(67, 13);
            this.lblIdTurma.TabIndex = 1;
            this.lblIdTurma.Text = "Id da Turma:";
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Location = new System.Drawing.Point(29, 92);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(75, 13);
            this.lblCpfAluno.TabIndex = 0;
            this.lblCpfAluno.Text = "CPF do Aluno:";
            // 
            // FrmDesmatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 259);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDesmatricularAluno";
            this.Text = "FrmDesmatricularAluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesmatricular;
        private System.Windows.Forms.Label lblIdTurma;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.TextBox txtIdTurma;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
    }
}