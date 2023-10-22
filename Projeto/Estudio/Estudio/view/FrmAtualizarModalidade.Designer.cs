
namespace Estudio.view
{
    partial class FrmAtualizarModalidade
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
            this.gbModalidades = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModalidades
            // 
            this.gbModalidades.Controls.Add(this.txtDescricao);
            this.gbModalidades.Controls.Add(this.cbId);
            this.gbModalidades.Controls.Add(this.lblId);
            this.gbModalidades.Controls.Add(this.cbAtivo);
            this.gbModalidades.Controls.Add(this.lblAtivo);
            this.gbModalidades.Controls.Add(this.btnAtualizar);
            this.gbModalidades.Controls.Add(this.txtQtdeAulas);
            this.gbModalidades.Controls.Add(this.txtQtdeAlunos);
            this.gbModalidades.Controls.Add(this.txtPreco);
            this.gbModalidades.Controls.Add(this.lblQtdeAulas);
            this.gbModalidades.Controls.Add(this.lblQtdeAlunos);
            this.gbModalidades.Controls.Add(this.lblPreco);
            this.gbModalidades.Controls.Add(this.lblDescricao);
            this.gbModalidades.Location = new System.Drawing.Point(32, 13);
            this.gbModalidades.Name = "gbModalidades";
            this.gbModalidades.Size = new System.Drawing.Size(354, 334);
            this.gbModalidades.TabIndex = 0;
            this.gbModalidades.TabStop = false;
            this.gbModalidades.Text = "Modalidades";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(111, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(202, 20);
            this.txtDescricao.TabIndex = 23;
            // 
            // cbId
            // 
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(111, 34);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(121, 21);
            this.cbId.TabIndex = 22;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            // 
            // cbAtivo
            // 
            this.cbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbAtivo.Location = new System.Drawing.Point(111, 235);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(202, 21);
            this.cbAtivo.TabIndex = 20;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(50, 237);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 19;
            this.lblAtivo.Text = "Ativo:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(44, 280);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(268, 28);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(159, 191);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.ReadOnly = true;
            this.txtQtdeAulas.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAulas.TabIndex = 16;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(159, 154);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.ReadOnly = true;
            this.txtQtdeAlunos.Size = new System.Drawing.Size(154, 20);
            this.txtQtdeAlunos.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(111, 116);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(202, 20);
            this.txtPreco.TabIndex = 14;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(44, 194);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(109, 13);
            this.lblQtdeAulas.TabIndex = 12;
            this.lblQtdeAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(44, 157);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(115, 13);
            this.lblQtdeAlunos.TabIndex = 11;
            this.lblQtdeAlunos.Text = "Quantidade de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(44, 118);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(44, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // FrmAtualizarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 365);
            this.Controls.Add(this.gbModalidades);
            this.Name = "FrmAtualizarModalidade";
            this.Text = "Atualizar Modalidade";
            this.gbModalidades.ResumeLayout(false);
            this.gbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModalidades;
        private System.Windows.Forms.ComboBox cbAtivo;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
    }
}