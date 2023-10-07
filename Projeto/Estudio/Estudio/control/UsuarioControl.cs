using Estudio.model;
using Estudio.modelDAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.control
{
    internal class UsuarioControl
    {
        public String logar(String username, String senha)
        {
            try
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                Usuario u = usuarioDAO.logar(username, senha);
                if(u != null)
                {
                    if (u.getSetTipo == 1)
                    {
                        return "Login realizado como Administrador!";
                    }
                    else if (u.getSetTipo == 2)
                    {
                        return "Login realizado como Restrito!";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
            return "Nome de usuário ou senha estão incorretos";
        }

        public void cadastrar(Usuario u)
        {
            try
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.cadastrar(u);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
        }   
    }
}
