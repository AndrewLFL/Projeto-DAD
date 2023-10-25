using Estudio.model;
using Estudio.modelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.control
{
    internal class AlunoTurmaControl
    {
        public bool matricular(AlunoTurma ta)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.matricular(ta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return false;
        }

        public bool desmatricular(AlunoTurma ta)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.desmatricular(ta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return false;
        }

        public int qtdeAlunosMatriculados(int idTurma)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.qtdeAlunosMatriculados(idTurma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return 0;
        }
    }
}
