using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private string professor, diaSemana, hora;
        private int modalidade;

        public Turma(string professor, string diaSemana, string hora, int modalidade)
        {
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.hora = hora;
            this.modalidade = modalidade;
        }


        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string diaSemana, int modalidade)
        {
            this.diaSemana = diaSemana;
            this.modalidade = modalidade;
        }

        public bool cadastrarTurma()
        {
            return false;
        }

        public bool excluirTurma()
        {
            return false;
        }

        /*
        public MySqlDataReader consultarTurma()
        {

        }

        public MySqlDataReader consultarTurma01()
        {

        }
        */

        public string Professor { get => professor; set => professor = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
    }
}
