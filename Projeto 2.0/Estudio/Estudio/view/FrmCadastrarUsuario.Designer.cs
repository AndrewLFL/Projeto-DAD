namespace Estudio.view
{
    partial class FrmCadastrarUsuario
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
            gbDados = new GroupBox();
            btnCadastrar = new Button();
            cbbTipo = new ComboBox();
            lblTipo = new Label();
            txtSenha = new TextBox();
            txtUsername = new TextBox();
            lblSenha = new Label();
            lblUsername = new Label();
            gbDados.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Controls.Add(btnCadastrar);
            gbDados.Controls.Add(cbbTipo);
            gbDados.Controls.Add(lblTipo);
            gbDados.Controls.Add(txtSenha);
            gbDados.Controls.Add(txtUsername);
            gbDados.Controls.Add(lblSenha);
            gbDados.Controls.Add(lblUsername);
            gbDados.Location = new Point(31, 28);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(595, 282);
            gbDados.TabIndex = 0;
            gbDados.TabStop = false;
            gbDados.Text = "Dados";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(53, 225);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(472, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cbbTipo
            // 
            cbbTipo.FormattingEnabled = true;
            cbbTipo.Items.AddRange(new object[] { "Administrador", "Restrito" });
            cbbTipo.Location = new Point(182, 160);
            cbbTipo.Name = "cbbTipo";
            cbbTipo.Size = new Size(158, 23);
            cbbTipo.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(53, 163);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(182, 96);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(343, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(182, 42);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(343, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(53, 104);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(53, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(102, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome de Usuário:";
            // 
            // FrmCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 332);
            Controls.Add(gbDados);
            Name = "FrmCadastrarUsuario";
            Text = "Cadastrar Usuário";
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDados;
        private Button btnCadastrar;
        private ComboBox cbbTipo;
        private Label lblTipo;
        private TextBox txtSenha;
        private TextBox txtUsername;
        private Label lblSenha;
        private Label lblUsername;
    }
}