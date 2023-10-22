
namespace Estudio.view
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mitArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mitSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExcluirAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAtualizarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitModalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCadastrarModalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExcluirModalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAtualizarModalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mitTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCadastrarTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExcluirTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAtualizarTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.mitConsultarTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.gbValidacao = new System.Windows.Forms.GroupBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.consultarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.gbValidacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Enabled = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitArquivo,
            this.mitAluno,
            this.mitModalidade,
            this.mitTurma});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(971, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mitArquivo
            // 
            this.mitArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCadastrarUsuario,
            this.toolStripSeparator,
            this.mitSair});
            this.mitArquivo.Name = "mitArquivo";
            this.mitArquivo.Size = new System.Drawing.Size(61, 20);
            this.mitArquivo.Text = "Arquivo";
            // 
            // mitCadastrarUsuario
            // 
            this.mitCadastrarUsuario.Name = "mitCadastrarUsuario";
            this.mitCadastrarUsuario.Size = new System.Drawing.Size(174, 22);
            this.mitCadastrarUsuario.Text = "Cadastrar Usuário";
            this.mitCadastrarUsuario.Click += new System.EventHandler(this.mitCadastrarUsuario_Click);
            // 
            // mitSair
            // 
            this.mitSair.Name = "mitSair";
            this.mitSair.Size = new System.Drawing.Size(174, 22);
            this.mitSair.Text = "Sair";
            this.mitSair.Click += new System.EventHandler(this.mitSair_Click);
            // 
            // mitAluno
            // 
            this.mitAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCadastrarAluno,
            this.mitExcluirAluno,
            this.mitAtualizarAluno,
            this.consultarAlunoToolStripMenuItem});
            this.mitAluno.Name = "mitAluno";
            this.mitAluno.Size = new System.Drawing.Size(51, 20);
            this.mitAluno.Text = "Aluno";
            // 
            // mitCadastrarAluno
            // 
            this.mitCadastrarAluno.Name = "mitCadastrarAluno";
            this.mitCadastrarAluno.Size = new System.Drawing.Size(159, 22);
            this.mitCadastrarAluno.Text = "Cadastrar Aluno";
            this.mitCadastrarAluno.Click += new System.EventHandler(this.mitCadastrarAluno_Click);
            // 
            // mitExcluirAluno
            // 
            this.mitExcluirAluno.Name = "mitExcluirAluno";
            this.mitExcluirAluno.Size = new System.Drawing.Size(159, 22);
            this.mitExcluirAluno.Text = "Excluir Aluno";
            this.mitExcluirAluno.Click += new System.EventHandler(this.mitExcluirAluno_Click);
            // 
            // mitAtualizarAluno
            // 
            this.mitAtualizarAluno.Name = "mitAtualizarAluno";
            this.mitAtualizarAluno.Size = new System.Drawing.Size(159, 22);
            this.mitAtualizarAluno.Text = "Atualizar Aluno";
            this.mitAtualizarAluno.Click += new System.EventHandler(this.mitAtualizarAluno_Click);
            // 
            // mitModalidade
            // 
            this.mitModalidade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCadastrarModalidade,
            this.mitExcluirModalidade,
            this.mitAtualizarModalidade,
            this.consultarModalidadeToolStripMenuItem});
            this.mitModalidade.Name = "mitModalidade";
            this.mitModalidade.Size = new System.Drawing.Size(82, 20);
            this.mitModalidade.Text = "Modalidade";
            // 
            // mitCadastrarModalidade
            // 
            this.mitCadastrarModalidade.Name = "mitCadastrarModalidade";
            this.mitCadastrarModalidade.Size = new System.Drawing.Size(190, 22);
            this.mitCadastrarModalidade.Text = "Cadastrar Modalidade";
            this.mitCadastrarModalidade.Click += new System.EventHandler(this.mitCadastrarModalidade_Click);
            // 
            // mitExcluirModalidade
            // 
            this.mitExcluirModalidade.Name = "mitExcluirModalidade";
            this.mitExcluirModalidade.Size = new System.Drawing.Size(190, 22);
            this.mitExcluirModalidade.Text = "Excluir Modalidade";
            this.mitExcluirModalidade.Click += new System.EventHandler(this.mitExcluirModalidade_Click);
            // 
            // mitAtualizarModalidade
            // 
            this.mitAtualizarModalidade.Name = "mitAtualizarModalidade";
            this.mitAtualizarModalidade.Size = new System.Drawing.Size(190, 22);
            this.mitAtualizarModalidade.Text = "Atualizar Modalidade";
            this.mitAtualizarModalidade.Click += new System.EventHandler(this.mitAtualizarModalidade_Click);
            // 
            // mitTurma
            // 
            this.mitTurma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCadastrarTurma,
            this.mitExcluirTurma,
            this.mitAtualizarTurma,
            this.mitConsultarTurma});
            this.mitTurma.Name = "mitTurma";
            this.mitTurma.Size = new System.Drawing.Size(53, 20);
            this.mitTurma.Text = "Turma";
            // 
            // mitCadastrarTurma
            // 
            this.mitCadastrarTurma.Name = "mitCadastrarTurma";
            this.mitCadastrarTurma.Size = new System.Drawing.Size(162, 22);
            this.mitCadastrarTurma.Text = "Cadastrar Turma";
            this.mitCadastrarTurma.Click += new System.EventHandler(this.mitCadastrarTurma_Click);
            // 
            // mitExcluirTurma
            // 
            this.mitExcluirTurma.Name = "mitExcluirTurma";
            this.mitExcluirTurma.Size = new System.Drawing.Size(162, 22);
            this.mitExcluirTurma.Text = "Excluir Turma ";
            this.mitExcluirTurma.Click += new System.EventHandler(this.mitExcluirTurma_Click);
            // 
            // mitAtualizarTurma
            // 
            this.mitAtualizarTurma.Name = "mitAtualizarTurma";
            this.mitAtualizarTurma.Size = new System.Drawing.Size(162, 22);
            this.mitAtualizarTurma.Text = "Atualizar Turma";
            this.mitAtualizarTurma.Click += new System.EventHandler(this.mitAtualizarTurma_Click);
            // 
            // mitConsultarTurma
            // 
            this.mitConsultarTurma.Name = "mitConsultarTurma";
            this.mitConsultarTurma.Size = new System.Drawing.Size(162, 22);
            this.mitConsultarTurma.Text = "Consultar Turma";
            this.mitConsultarTurma.Click += new System.EventHandler(this.mitConsultarTurma_Click);
            // 
            // gbValidacao
            // 
            this.gbValidacao.Controls.Add(this.btnLogar);
            this.gbValidacao.Controls.Add(this.txtSenha);
            this.gbValidacao.Controls.Add(this.txtUsername);
            this.gbValidacao.Controls.Add(this.lblSenha);
            this.gbValidacao.Controls.Add(this.lblUsername);
            this.gbValidacao.Location = new System.Drawing.Point(331, 119);
            this.gbValidacao.Name = "gbValidacao";
            this.gbValidacao.Size = new System.Drawing.Size(348, 202);
            this.gbValidacao.TabIndex = 2;
            this.gbValidacao.TabStop = false;
            this.gbValidacao.Text = "Validação";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(39, 149);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(272, 27);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(130, 94);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(181, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "2343";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "carla";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(39, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(39, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nome de usuario:";
            // 
            // consultarAlunoToolStripMenuItem
            // 
            this.consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            this.consultarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAlunoToolStripMenuItem.Text = "Consultar Aluno";
            this.consultarAlunoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlunoToolStripMenuItem_Click);
            // 
            // consultarModalidadeToolStripMenuItem
            // 
            this.consultarModalidadeToolStripMenuItem.Name = "consultarModalidadeToolStripMenuItem";
            this.consultarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarModalidadeToolStripMenuItem.Text = "Consultar Modalidade";
            this.consultarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.consultarModalidadeToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 451);
            this.Controls.Add(this.gbValidacao);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "Estúdio";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbValidacao.ResumeLayout(false);
            this.gbValidacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mitArquivo;
        private System.Windows.Forms.ToolStripMenuItem mitAluno;
        private System.Windows.Forms.ToolStripMenuItem mitModalidade;
        private System.Windows.Forms.GroupBox gbValidacao;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mitSair;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem mitExcluirAluno;
        private System.Windows.Forms.ToolStripMenuItem mitAtualizarAluno;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitExcluirModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitAtualizarModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitTurma;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarTurma;
        private System.Windows.Forms.ToolStripMenuItem mitExcluirTurma;
        private System.Windows.Forms.ToolStripMenuItem mitAtualizarTurma;
        private System.Windows.Forms.ToolStripMenuItem mitConsultarTurma;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarModalidadeToolStripMenuItem;
    }
}