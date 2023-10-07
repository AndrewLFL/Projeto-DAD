using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.connection
{
    internal class Conexao
    {
        private String local = "143.106.241.3";
        private String banco = "cl202230";
        private String user = "cl202230";
        private String senha = "NamesCode";

        public MySqlConnection getConnection()
        {
            try
            {
                return new MySqlConnection($"server= {local} ;User ID= {user} ;database= {banco}; password={senha}; SslMode = none");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na conexão com o Banco de Dados: " + e.Message);
            }
            return null;
        }
    }
}
