using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Usuario
    {
        private String username;
        private String senha;
        private int tipo;

        public Usuario()
        {
        }

        public Usuario(string username, string senha, int tipo)
        {
            this.username = username;
            this.senha = senha;
            this.tipo = tipo;
        }

        public string getSetUsername { get => username; set => username = value; }
        public string getSetSenha { get => senha; set => senha = value; }
        public int getSetTipo { get => tipo; set => tipo = value; }
    }
}
