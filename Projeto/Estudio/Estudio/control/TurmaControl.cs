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
    }
}
