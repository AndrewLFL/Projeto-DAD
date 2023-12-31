﻿using Estudio.control;
using Estudio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.view
{
    public partial class FrmCadastrarTurma : Form
    {

        private ModalidadeControl mc;
        private TurmaControl tc;

        public FrmCadastrarTurma()
        {
            InitializeComponent();
            mc = new ModalidadeControl();
            tc = new TurmaControl();
            try
            {
                List<String> modalidades = mc.consultarTodasModalidadesAtivas();
                foreach (String mod in modalidades)
                {
                    dgvTurma.Rows.Add(mod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar modalidades: " + ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaSemana.Text == "" || txtHorario.Text == "" || txtModalidade.Text == "" || txtProfessor.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                int modalidade = mc.buscarPorDescricao(txtModalidade.Text).getSetId;
                Turma t = new Turma(modalidade, txtProfessor.Text, txtDiaSemana.Text, txtHorario.Text);
                if (tc.cadastrar(t))
                {
                    MessageBox.Show("Turma cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar turma!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma:" + ex.Message);
            }
        }

        private void dgvTurma_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtModalidade.Text = dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
