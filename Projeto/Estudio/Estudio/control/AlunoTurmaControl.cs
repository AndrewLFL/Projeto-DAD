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

        public bool desmatricular(int id)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.desmatricular(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return false;
        }

        public bool excluirMatriculasPorAluno(String cpf)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.excluirMatriculasPorAluno(cpf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return false;
        }

        public bool excluirMatriculasPorTurma(int id)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.excluirMatriculasPorTurma(id);
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

        public List<String> consultarTodasAlunoTurma()
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.consultarTodasAlunoTurma();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return null;
        }

        public List<String> consultarTodosAlunoPorTurma(int turma)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.consultarTodosAlunoPorTurma(turma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return null;
        }

        public List<int> consultarTodasTurmasPorAluno(String aluno)
        {
            try
            {
                AlunoTurmaDAO turmaAlunoDAO = new AlunoTurmaDAO();
                return turmaAlunoDAO.consultarTodasTurmasPorAluno(aluno);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            return null;
        }

        public AlunoTurma buscar(int id)
        {
            try
            {
                AlunoTurmaDAO alunoTurmaDAO = new AlunoTurmaDAO();
                return alunoTurmaDAO.buscar(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }
    }
}
