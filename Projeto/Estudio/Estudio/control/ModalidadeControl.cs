using Estudio.model;
using Estudio.modelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.control
{
    internal class ModalidadeControl
    {
        public bool cadastrar(Modalidade mod)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.cadastrar(mod);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
                return false;
        }

        public List<String> consultarTodasModalidades()
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.consultarTodasModalidades();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
            return null;
        }

        public List<String> consultarTodasModalidadesAtivas()
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.consultarTodasModalidadesAtivas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
            return null;
        }

        public bool excluir(String descricao)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.excluir(descricao);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir: " + ex.Message);
            }
            return false;
        }

        public bool atualizar(Modalidade mod)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.atualizar(mod);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            return false;
        }

        public Modalidade buscar(String descricao)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.buscar(descricao);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }
    }
}
