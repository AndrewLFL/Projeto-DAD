namespace Estudio.view
{
    partial class FrmMatricularAluno
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
            this.cbCpfAluno = new System.Windows.Forms.ComboBox();
            this.cbIdTurma = new System.Windows.Forms.ComboBox();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblIdTurma = new System.Windows.Forms.Label();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMatricular);
            this.groupBox1.Controls.Add(this.lblIdTurma);
            this.groupBox1.Controls.Add(this.lblCpfAluno);
            this.groupBox1.Controls.Add(this.cbIdTurma);
            this.groupBox1.Controls.Add(this.cbCpfAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matricular";
            // 
            // cbCpfAluno
            // 
            this.cbCpfAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCpfAluno.FormattingEnabled = true;
            this.cbCpfAluno.Location = new System.Drawing.Point(98, 62);
            this.cbCpfAluno.Name = "cbCpfAluno";
            this.cbCpfAluno.Size = new System.Drawing.Size(152, 21);
            this.cbCpfAluno.TabIndex = 0;
            // 
            // cbIdTurma
            // 
            this.cbIdTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTurma.FormattingEnabled = true;
            this.cbIdTurma.Location = new System.Drawing.Point(98, 110);
            this.cbIdTurma.Name = "cbIdTurma";
            this.cbIdTurma.Size = new System.Drawing.Size(152, 21);
            this.cbIdTurma.TabIndex = 1;
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Location = new System.Drawing.Point(17, 65);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(75, 13);
            this.lblCpfAluno.TabIndex = 2;
            this.lblCpfAluno.Text = "CPF do Aluno:";
            // 
            // lblIdTurma
            // 
            this.lblIdTurma.AutoSize = true;
            this.lblIdTurma.Location = new System.Drawing.Point(17, 113);
            this.lblIdTurma.Name = "lblIdTurma";
            this.lblIdTurma.Size = new System.Drawing.Size(69, 13);
            this.lblIdTurma.TabIndex = 3;
            this.lblIdTurma.Text = "ID da Turma:";
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(20, 167);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(230, 27);
            this.btnMatricular.TabIndex = 4;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // FrmMatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 259);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMatricularAluno";
            this.Text = "Matricular Aluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Label lblIdTurma;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.ComboBox cbIdTurma;
        private System.Windows.Forms.ComboBox cbCpfAluno;
    }
}