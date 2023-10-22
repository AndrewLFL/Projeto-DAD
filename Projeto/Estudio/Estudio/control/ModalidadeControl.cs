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

        public List<int> consultarTodasModalidades()
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

        public List<int> consultarTodasModalidadesAtivasId()
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.consultarTodasModalidadesAtivasId();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar: " + ex.Message);
            }
            return null;
        }

        public bool excluir(int id)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.excluir(id);
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

        public Modalidade buscar(int id)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.buscar(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }

        public Modalidade buscarPorDescricao(String descricao)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.buscarPorDescricao(descricao);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }

        public String buscarDescricao(int id)
        {
            try
            {
                ModalidadeDAO modalidadeDAO = new ModalidadeDAO();
                return modalidadeDAO.buscarDescricao(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            return null;
        }
    }
}
