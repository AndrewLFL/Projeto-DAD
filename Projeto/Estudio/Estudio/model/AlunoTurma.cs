using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class AlunoTurma
    {
        private int id;
        private string cpfAluno;
        private int idTurma;

        public AlunoTurma(string cpfAluno, int idTurma)
        {
            this.cpfAluno = cpfAluno;
            this.idTurma = idTurma;
        }

        public AlunoTurma(int id, string cpfAluno, int idTurma)
        {
            this.id = id;
            this.cpfAluno = cpfAluno;
            this.idTurma = idTurma;
        }

        public int getSetId { get => id; set => id = value; }
        public string getSetCpfAluno { get => cpfAluno; set => cpfAluno = value; }
        public int getSetIdTurma { get => idTurma; set => idTurma = value; }
    }
}
