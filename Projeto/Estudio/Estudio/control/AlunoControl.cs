using Estudio.model;
using Estudio.modelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.control
{
    internal class AlunoControl
    {
        public bool cadastrar(Aluno al)
        {
            try
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                return alunoDAO.cadastrar(al);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
                return false;
        }

        public bool consultar(String cpf)
        {
            try
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                return alunoDAO.consultar(cpf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            return false;
        }   

        public bool excluir(String cpf)
        {
            try
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                return alunoDAO.excluir(cpf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir: " + ex.Message);
            }
            return false;
        }

        public Aluno buscar(String cpf)
        {
            try
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                return alunoDAO.buscar(cpf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }

        public bool atualizar(Aluno al)
        {
            try
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                return alunoDAO.atualizar(al);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            return false;
        }
    }
}
