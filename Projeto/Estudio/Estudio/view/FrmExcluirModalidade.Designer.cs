namespace Estudio.view
{
    partial class FrmExcluirModalidade
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
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            lblDescricao = new Label();
            cbDescricao = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(cbDescricao);
            groupBox1.Location = new Point(35, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modalidades";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(16, 110);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(329, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(16, 55);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição:";
            // 
            // cbDescricao
            // 
            cbDescricao.FormattingEnabled = true;
            cbDescricao.Location = new Point(83, 52);
            cbDescricao.Name = "cbDescricao";
            cbDescricao.Size = new Size(262, 23);
            cbDescricao.TabIndex = 0;
            // 
            // FrmExcluirModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 224);
            Controls.Add(groupBox1);
            Name = "FrmExcluirModalidade";
            Text = "Excluir Modalidade";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExcluir;
        private Label lblDescricao;
        private ComboBox cbDescricao;
    }
}