using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Modalidade
    {
        private int id;
        private String descricao;
        private double preco;
        private int qtdeAlunos;
        private int qtdeAulas;
        private int ativo;

        public Modalidade(string descricao, double preco, int qtdeAlunos, int qtdeAulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtdeAlunos = qtdeAlunos;
            this.qtdeAulas = qtdeAulas;
        }

        public Modalidade(string descricao, double preco, int qtdeAlunos, int qtdeAulas, int ativo)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtdeAlunos = qtdeAlunos;
            this.qtdeAulas = qtdeAulas;
            this.ativo = ativo;
        }

        public Modalidade(int id, string descricao, double preco, int qtdeAlunos, int qtdeAulas, int ativo)
        {
            this.id = id;
            this.descricao = descricao;
            this.preco = preco;
            this.qtdeAlunos = qtdeAlunos;
            this.qtdeAulas = qtdeAulas;
            this.ativo = ativo;
        }

        public string getSetDescricao { get => descricao; set => descricao = value; }
        public double getSetPreco { get => preco; set => preco = value; }
        public int getSetQtdeAlunos { get => qtdeAlunos; set => qtdeAlunos = value; }
        public int getSetQtdeAulas { get => qtdeAulas; set => qtdeAulas = value; }
        public int getSetAtivo { get => ativo; set => ativo = value; }

        public int getSetId { get => id; set => id = value; }
    }
}
