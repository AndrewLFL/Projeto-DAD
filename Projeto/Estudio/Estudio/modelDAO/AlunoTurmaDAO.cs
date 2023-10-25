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
        public bool desmatricular(AlunoTurma ta)
        {
            bool mat = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"DELETE FROM EstudioAlunoTurma (aluno,turma) VALUES ('{ta.getSetCpfAluno}', {ta.getSetIdTurma})", con);
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
    }

    
}
