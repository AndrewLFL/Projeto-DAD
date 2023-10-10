using Estudio.model;
using Estudio.modelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.control
{
    internal class TurmaControl
    {
        public bool cadastrar(Turma turma)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.cadastrar(turma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
            return false;
        }

        public List<String> consultarTodasTurmasAtivas()
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.consultarTodasTurmasAtivas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            return null;
        }

        public bool excluir(int id)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.excluir(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir: " + ex.Message);
            }
            return false;
        }

        public Turma buscar(int id)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.buscar(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }
    }
}
