
using System;

namespace Estudio
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mitArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbValidacao = new System.Windows.Forms.GroupBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.atualizarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cadastrarUsuárioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mitSair});
            this.mitArquivo.Name = "mitArquivo";
            this.mitArquivo.Size = new System.Drawing.Size(61, 20);
            this.mitArquivo.Text = "Arquivo";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem2.Text = "____________________";
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
            this.mitAtualizarAluno});
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
            this.mitAtualizarModalidade});
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
            this.excluirTurmaToolStripMenuItem,
            this.atualizarTurmaToolStripMenuItem});
            this.mitTurma.Name = "mitTurma";
            this.mitTurma.Size = new System.Drawing.Size(53, 20);
            this.mitTurma.Text = "Turma";
            // 
            // mitCadastrarTurma
            // 
            this.mitCadastrarTurma.Name = "mitCadastrarTurma";
            this.mitCadastrarTurma.Size = new System.Drawing.Size(180, 22);
            this.mitCadastrarTurma.Text = "Cadastrar Turma";
            this.mitCadastrarTurma.Click += new System.EventHandler(this.mitCadastrarTurma_Click);
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma ";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
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
            this.btnLogar.Size = new System.Drawing.Size(272, 20);
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
            // atualizarTurmaToolStripMenuItem
            // 
            this.atualizarTurmaToolStripMenuItem.Name = "atualizarTurmaToolStripMenuItem";
            this.atualizarTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarTurmaToolStripMenuItem.Text = "Atualizar Turma";
            this.atualizarTurmaToolStripMenuItem.Click += new System.EventHandler(this.atualizarTurmaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mitSair;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem mitExcluirAluno;
        private System.Windows.Forms.ToolStripMenuItem mitAtualizarAluno;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitExcluirModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitAtualizarModalidade;
        private System.Windows.Forms.ToolStripMenuItem mitTurma;
        private System.Windows.Forms.ToolStripMenuItem mitCadastrarTurma;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarTurmaToolStripMenuItem;
    }
}

