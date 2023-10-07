namespace Estudio
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mitArquivo = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            mitSair = new ToolStripMenuItem();
            mitAluno = new ToolStripMenuItem();
            mitCadastrarAluno = new ToolStripMenuItem();
            mitExcluirAluno = new ToolStripMenuItem();
            mitAtualizarAluno = new ToolStripMenuItem();
            mitModalidade = new ToolStripMenuItem();
            mitCadastrarModalidade = new ToolStripMenuItem();
            mitExcluirModalidade = new ToolStripMenuItem();
            mitAtualizarModalidade = new ToolStripMenuItem();
            mitTurma = new ToolStripMenuItem();
            mitCadastrarTurma = new ToolStripMenuItem();
            gbValidacao = new GroupBox();
            btnLogar = new Button();
            txtSenha = new TextBox();
            txtUsername = new TextBox();
            lblSenha = new Label();
            lblUsername = new Label();
            menuStrip.SuspendLayout();
            gbValidacao.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Enabled = false;
            menuStrip.Items.AddRange(new ToolStripItem[] { mitArquivo, mitAluno, mitModalidade, mitTurma });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1133, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // mitArquivo
            // 
            mitArquivo.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuárioToolStripMenuItem, toolStripMenuItem2, mitSair });
            mitArquivo.Name = "mitArquivo";
            mitArquivo.Size = new Size(61, 20);
            mitArquivo.Text = "Arquivo";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(174, 22);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            cadastrarUsuárioToolStripMenuItem.Click += mitcadastrarUsuário_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(174, 22);
            toolStripMenuItem2.Text = "____________________";
            // 
            // mitSair
            // 
            mitSair.Name = "mitSair";
            mitSair.Size = new Size(174, 22);
            mitSair.Text = "Sair";
            mitSair.Click += mitSair_Click;
            // 
            // mitAluno
            // 
            mitAluno.DropDownItems.AddRange(new ToolStripItem[] { mitCadastrarAluno, mitExcluirAluno, mitAtualizarAluno });
            mitAluno.Name = "mitAluno";
            mitAluno.Size = new Size(51, 20);
            mitAluno.Text = "Aluno";
            mitAluno.Click += mitAluno_Click;
            // 
            // mitCadastrarAluno
            // 
            mitCadastrarAluno.Name = "mitCadastrarAluno";
            mitCadastrarAluno.Size = new Size(159, 22);
            mitCadastrarAluno.Text = "Cadastrar Aluno";
            // 
            // mitExcluirAluno
            // 
            mitExcluirAluno.Name = "mitExcluirAluno";
            mitExcluirAluno.Size = new Size(159, 22);
            mitExcluirAluno.Text = "Excluir Aluno";
            // 
            // mitAtualizarAluno
            // 
            mitAtualizarAluno.Name = "mitAtualizarAluno";
            mitAtualizarAluno.Size = new Size(159, 22);
            mitAtualizarAluno.Text = "Atualizar Aluno";
            // 
            // mitModalidade
            // 
            mitModalidade.DropDownItems.AddRange(new ToolStripItem[] { mitCadastrarModalidade, mitExcluirModalidade, mitAtualizarModalidade });
            mitModalidade.Name = "mitModalidade";
            mitModalidade.Size = new Size(82, 20);
            mitModalidade.Text = "Modalidade";
            // 
            // mitCadastrarModalidade
            // 
            mitCadastrarModalidade.Name = "mitCadastrarModalidade";
            mitCadastrarModalidade.Size = new Size(190, 22);
            mitCadastrarModalidade.Text = "Cadastrar Modalidade";
            // 
            // mitExcluirModalidade
            // 
            mitExcluirModalidade.Name = "mitExcluirModalidade";
            mitExcluirModalidade.Size = new Size(190, 22);
            mitExcluirModalidade.Text = "Excluir Modalidade";
            // 
            // mitAtualizarModalidade
            // 
            mitAtualizarModalidade.Name = "mitAtualizarModalidade";
            mitAtualizarModalidade.Size = new Size(190, 22);
            mitAtualizarModalidade.Text = "Atualizar Modalidade";
            // 
            // mitTurma
            // 
            mitTurma.DropDownItems.AddRange(new ToolStripItem[] { mitCadastrarTurma });
            mitTurma.Name = "mitTurma";
            mitTurma.Size = new Size(53, 20);
            mitTurma.Text = "Turma";
            // 
            // mitCadastrarTurma
            // 
            mitCadastrarTurma.Name = "mitCadastrarTurma";
            mitCadastrarTurma.Size = new Size(161, 22);
            mitCadastrarTurma.Text = "Cadastrar Turma";
            // 
            // gbValidacao
            // 
            gbValidacao.Controls.Add(btnLogar);
            gbValidacao.Controls.Add(txtSenha);
            gbValidacao.Controls.Add(txtUsername);
            gbValidacao.Controls.Add(lblSenha);
            gbValidacao.Controls.Add(lblUsername);
            gbValidacao.Location = new Point(386, 137);
            gbValidacao.Name = "gbValidacao";
            gbValidacao.Size = new Size(406, 233);
            gbValidacao.TabIndex = 2;
            gbValidacao.TabStop = false;
            gbValidacao.Text = "Validação";
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(45, 172);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(317, 23);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(152, 108);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(210, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "2343";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(152, 54);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "carla";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(45, 116);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(45, 57);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome de usuario:";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 520);
            Controls.Add(gbValidacao);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmMain";
            Text = "Estúdio";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            gbValidacao.ResumeLayout(false);
            gbValidacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mitArquivo;
        private ToolStripMenuItem mitAluno;
        private ToolStripMenuItem mitModalidade;
        private GroupBox gbValidacao;
        private Button btnLogar;
        private TextBox txtSenha;
        private TextBox txtUsername;
        private Label lblSenha;
        private Label lblUsername;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem mitSair;
        private ToolStripMenuItem mitCadastrarAluno;
        private ToolStripMenuItem mitExcluirAluno;
        private ToolStripMenuItem mitAtualizarAluno;
        private ToolStripMenuItem mitCadastrarModalidade;
        private ToolStripMenuItem mitExcluirModalidade;
        private ToolStripMenuItem mitAtualizarModalidade;
        private ToolStripMenuItem mitTurma;
        private ToolStripMenuItem mitCadastrarTurma;
    }
}