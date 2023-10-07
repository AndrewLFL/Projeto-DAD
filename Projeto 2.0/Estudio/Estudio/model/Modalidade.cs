using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Modalidade
    {
        private String descricao;
        private decimal preco;
        private int qtdeAlunos;
        private int qtdeAulas;

        public Modalidade(string descricao, decimal preco, int qtdeAlunos, int qtdeAulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtdeAlunos = qtdeAlunos;
            this.qtdeAulas = qtdeAulas;
        }

        public string getSetDescricao { get => descricao; set => descricao = value; }
        public decimal getSetPreco { get => preco; set => preco = value; }
        public int getSetQtdeAlunos { get => qtdeAlunos; set => qtdeAlunos = value; }
        public int getSetQtdeAulas { get => qtdeAulas; set => qtdeAulas = value; }
    }
}
