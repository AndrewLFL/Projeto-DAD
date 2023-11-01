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
    internal class TurmaDAO
    {
        private MySqlConnection con;

        public bool cadastrar(Turma turma)
        {
            bool cad = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO EstudioTurma (modalidade,professor,diaSemana,horario) VALUES ({turma.getSetModalidade}, '{turma.getSetProfessor}', '{turma.getSetDiaSemana}', '{turma.getSetHorario}')", con);
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

        public List<String> consultarTodasTurmas()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM EstudioTurma", con);
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

        public List<String> consultarTodasTurmasAtivas()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM EstudioTurma WHERE ativo = 1", con);
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

        public List<Turma> consultarTodasTurmasAtivasObjeto()
        {
            List<Turma> lista = new List<Turma>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM EstudioTurma WHERE ativo = 1", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Turma turma = new Turma(int.Parse(dr["modalidade"].ToString()), dr["professor"].ToString(), dr["diaSemana"].ToString(), dr["horario"].ToString(), int.Parse(dr["numAlunos"].ToString()), int.Parse(dr["ativo"].ToString()), int.Parse(dr["id"].ToString()));
                    lista.Add(turma);
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

        public bool consultarPorModalidade(int modalidade)
        {
            bool consulta = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioTurma WHERE modalidade = {modalidade}", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    consulta = true;
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
            return consulta;
        }


        public bool excluir(int id)
        {
            bool exc = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioTurma SET ativo = 0 WHERE id = {id}", con);
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

        public bool excluirPorModalidade(int modalidade)
        {
            bool exc = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioTurma SET ativo = 0 WHERE modalidade = {modalidade}", con);
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

        public Turma buscar(int id)
        {
            Turma turma = null;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioTurma WHERE id = {id}", con);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    turma = new Turma(int.Parse(dr["modalidade"].ToString()), dr["professor"].ToString(), dr["diaSemana"].ToString(), dr["horario"].ToString(), int.Parse(dr["numAlunos"].ToString()), int.Parse(dr["ativo"].ToString()), int.Parse(dr["id"].ToString()));
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
            return turma;
        }

        public bool atualizar(Turma t)
        {
            bool att = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioTurma SET professor = '{t.getSetProfessor}', diaSemana = '{t.getSetDiaSemana}', horario = '{t.getSetHorario}', ativo = {t.getSetAtivo} WHERE id = '{t.getSetId}'", con);
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

        public void atualizarNumAlunos(int id, int qtdeAlunos)
        {
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioTurma SET numAlunos = {qtdeAlunos} WHERE id = '{id}'", con);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
