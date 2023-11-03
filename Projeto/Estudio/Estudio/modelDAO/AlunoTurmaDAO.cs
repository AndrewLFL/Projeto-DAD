using Estudio.connection;
using Estudio.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.modelDAO
{
    internal class AlunoTurmaDAO
    {
        private MySqlConnection con;

        public bool matricular(AlunoTurma ta)
        {
            bool mat = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO EstudioAlunoTurma (aluno,turma) VALUES ('{ta.getSetCpfAluno}', {ta.getSetIdTurma})", con);
                sql.ExecuteNonQuery();
                mat = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return mat;
        }
        public bool desmatricular(int id)
        {
            bool mat = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"DELETE FROM EstudioAlunoTurma WHERE id = {id}", con);
                sql.ExecuteNonQuery();
                mat = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao desmatricular: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return mat;
        }

        public bool excluirMatriculasPorAluno(String cpf)
        {
            bool mat = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"DELETE FROM EstudioAlunoTurma WHERE aluno = '{cpf}'", con);
                sql.ExecuteNonQuery();
                mat = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Excluir Matriculas Por Aluno: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return mat;
        }

        public bool excluirMatriculasPorTurma(int id)
        {
            bool mat = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"DELETE FROM EstudioAlunoTurma WHERE turma = {id}", con);
                sql.ExecuteNonQuery();
                mat = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Excluir Matriculas Por Turma: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return mat;
        }

        public List<String> consultarTodasAlunoTurma()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM EstudioAlunoTurma", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lista;
        }

        public List<String> consultarTodosAlunoPorTurma(int turma)
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAlunoTurma WHERE turma = {turma}", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["aluno"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lista;
        }

        public List<int> consultarTodasTurmasPorAluno(String aluno)
        {
            List<int> lista = new List<int>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAlunoTurma WHERE aluno = '{aluno}'", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(int.Parse(dr["turma"].ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lista;
        }

        public int qtdeAlunosMatriculados(int idTurma)
        {
            int qtde = 0;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT count(aluno) from EstudioAlunoTurma where turma = {idTurma}", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    qtde = dr.GetInt32("count(aluno)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao matricular: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return qtde;
        }

        public AlunoTurma buscar(int id)
        {
            AlunoTurma at = null;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAlunoTurma WHERE id = {id}", con);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    at = new AlunoTurma(dr["aluno"].ToString(), Convert.ToInt32(dr["turma"].ToString()));
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
            return at;
        }
    }
}
