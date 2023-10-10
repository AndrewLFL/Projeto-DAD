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
                    turma = new Turma(int.Parse(dr["modalidade"].ToString()), dr["professor"].ToString(), dr["diaSemana"].ToString(), dr["horario"].ToString());
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
    }
}
