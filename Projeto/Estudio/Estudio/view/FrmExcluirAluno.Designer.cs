namespace Estudio.view
{
    partial class FrmExcluirAluno
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
            lblCpf = new Label();
            mtxtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(36, 53);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(29, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf:";
            // 
            // mtxtCpf
            // 
            mtxtCpf.Location = new Point(99, 50);
            mtxtCpf.Mask = "000,000,000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(151, 23);
            mtxtCpf.TabIndex = 1;
            mtxtCpf.KeyPress += mtxtCpf_KeyPress;
            // 
            // FrmExcluirAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 116);
            Controls.Add(mtxtCpf);
            Controls.Add(lblCpf);
            Name = "FrmExcluirAluno";
            Text = "Excluir Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCpf;
        private MaskedTextBox mtxtCpf;
    }
}