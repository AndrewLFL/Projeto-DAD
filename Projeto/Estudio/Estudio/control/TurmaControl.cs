﻿using Estudio.model;
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

        public List<Turma> consultarTodasTurmasAtivasObjeto()
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.consultarTodasTurmasAtivasObjeto();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            return null;
        }

        public List<String> consultarTodasTurmas()
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.consultarTodasTurmas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            return null;
        }

        public bool consultarPorModalidade(int id)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.consultarPorModalidade(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            return false;
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

        public bool excluirPorModalidade(int modalidade)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.excluirPorModalidade(modalidade);
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

        public bool atualizar(Turma t)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                return turmaDAO.atualizar(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            return false;
        }

        public void atualizarNumAlunos(int id, int qtdeAlunos)
        {
            try
            {
                TurmaDAO turmaDAO = new TurmaDAO();
                turmaDAO.atualizarNumAlunos(id, qtdeAlunos);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
        }
    }
}
