using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Turma
    {
        private int modalidade;
        private String professor;
        private String diaSemana;
        private String horario;
        private int numAlunos;

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

        public int getSetModalidade { get => modalidade; set => modalidade = value; }
        public string getSetProfessor { get => professor; set => professor = value; }
        public string getSetDiaSemana { get => diaSemana; set => diaSemana = value; }
        public string getSetHorario { get => horario; set => horario = value; }
        public int getSetNumAlunos { get => numAlunos; set => numAlunos = value; }
    }
}
