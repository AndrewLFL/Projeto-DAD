using Estudio.connection;
using Estudio.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.modelDAO
{
    internal class ModalidadeDAO
    {
        private MySqlConnection con;

        public bool cadastrar(Modalidade mod)
        {
            bool cad = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO EstudioModalidade (descricao,preco,qtdeAlunos,qtdeAulas) VALUES ('{mod.getSetDescricao}', {mod.getSetPreco.ToString().Replace(',', '.')}, {mod.getSetQtdeAlunos}, {mod.getSetQtdeAulas})", con);
                sql.ExecuteNonQuery(); 
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public List<String> consultarTodasModalidades()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioModalidade", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString("descricao"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na consulta: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lista;
        }

        public List<String> consultarTodasModalidadesAtivas()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioModalidade WHERE ativo = 1 ", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString("descricao"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na consulta: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lista;
        }

        public bool excluir(String descricao)
        {
            bool exc = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioModalidade SET ativo = 0 WHERE descricao = '{descricao}'", con);
                sql.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return exc;
        }

        public bool atualizar(Modalidade mod)
        {
            bool att = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioModalidade SET preco = {mod.getSetPreco.ToString().Replace(',','.')}, qtdeAlunos = {mod.getSetQtdeAlunos}, qtdeAulas = {mod.getSetQtdeAulas}, ativo = {mod.getSetAtivo} WHERE descricao = '{mod.getSetDescricao}'", con);
                sql.ExecuteNonQuery();
                att = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return att;
        }

        public Modalidade buscar(String descricao)
        {
            Modalidade mod = null;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioModalidade WHERE descricao = '{descricao}'", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    mod = new Modalidade(dr.GetInt32("id"), dr.GetString("descricao"), dr.GetDouble("preco"), dr.GetInt32("qtdeAlunos"), dr.GetInt32("qtdeAulas"), dr.GetInt32("ativo"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return mod;
        }
    }
}
