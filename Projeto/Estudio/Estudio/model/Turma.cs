using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Turma
    {
        private int id;
        private int modalidade;
        private String professor;
        private String diaSemana;
        private String horario;
        private int numAlunos;
        private int ativo;

        public Turma(int modalidade, string professor, string diaSemana, string horario, int numAlunos)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.horario = horario;
            this.numAlunos = numAlunos;
        }

        public Turma(int modalidade, string professor, string diaSemana, string horario)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.horario = horario;
        }

        public Turma(int modalidade, string professor, string diaSemana, string horario, int numAlunos, int ativo)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.horario = horario;
            this.numAlunos = numAlunos;
            this.ativo = ativo;
        }


        public Turma(int modalidade, string professor, string diaSemana, string horario, int numAlunos, int ativo, int id)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.horario = horario;
            this.numAlunos = numAlunos;
            this.ativo = ativo;
            this.id = id;
        }

        public int getSetModalidade { get => modalidade; set => modalidade = value; }
        public string getSetProfessor { get => professor; set => professor = value; }
        public string getSetDiaSemana { get => diaSemana; set => diaSemana = value; }
        public string getSetHorario { get => horario; set => horario = value; }
        public int getSetNumAlunos { get => numAlunos; set => numAlunos = value; }
        public int getSetAtivo { get => ativo; set => ativo = value; }
        public int getSetId { get => id; set => id = value; }
    }
}
