using Estudio.connection;
using Estudio.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.modelDAO
{
    internal class UsuarioDAO
    {
        private MySqlConnection con;

        public Usuario logar (String username, String senha)
        {
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioUsuario WHERE username = '{username}' and senha = '{senha}' ", con);
                MySqlDataReader r = sql.ExecuteReader();
                Console.WriteLine(r);
                Usuario u = new Usuario();
                if(r != null)
                {
                    if (r.HasRows)
                    {
                        r.Read();
                        u.getSetUsername = r.GetString(0);
                        u.getSetSenha = r.GetString(1);
                        u.getSetTipo = r.GetInt32(2);
                        return u;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public void cadastrar(Usuario u)
        {

            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO EstudioUsuario (username,senha,tipo) VALUES ('{u.getSetUsername}', '{u.getSetSenha}', {u.getSetTipo})", con);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }   
    }
}
