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
    internal class AlunoDAO
    {
        private MySqlConnection con;

        public bool cadastrar(Aluno al)
        {
            bool cad = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO EstudioAluno (cpf,nome,endereco,numero,bairro,complemento,cep,cidade,estado,telefone,email,foto) VALUES ('{al.getSetCpf}', '{al.getSetNome}', '{al.getSetEndereco}', '{al.getSetNumero}', '{al.getSetBairro}', '{al.getSetComplemento}', '{al.getSetCep}', '{al.getSetCidade}', '{al.getSetEstado}', '{al.getSetTelefone}', '{al.getSetEmail}', '{al.getSetFoto}')", con);
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

        public bool consultar(String cpf)
        {
            bool cons = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAluno WHERE cpf = '{cpf}'", con);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    cons = true;
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
            return cons;
        }

        public List<String> consultarTodosAlunos()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAluno", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString("cpf"));
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

        public List<String> consultarTodosAlunosAtivos()
        {
            List<String> lista = new List<String>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAluno where ativo = 1", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString("cpf"));
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

        public List<Aluno> consultarTodosAlunosAtivosObjeto()
        {
            List<Aluno> lista = new List<Aluno>();
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAluno where ativo = 1", con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Aluno aluno = new Aluno(dr["cpf"].ToString(), dr["nome"].ToString(), dr["endereco"].ToString(), dr["numero"].ToString(), dr["bairro"].ToString(), dr["complemento"].ToString(), dr["cep"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["telefone"].ToString(), dr["email"].ToString());
                    lista.Add(aluno);
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

        public bool excluir(String cpf)
        {
            bool exc = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioAluno SET ativo = 0 WHERE cpf = '{cpf}'", con);
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

        public Aluno buscar(String cpf)
        {
            Aluno al = null;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM EstudioAluno WHERE cpf = '{cpf}'", con);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    al = new Aluno(dr["cpf"].ToString(), dr["nome"].ToString(), dr["endereco"].ToString(), dr["numero"].ToString(), dr["bairro"].ToString(), dr["complemento"].ToString(), dr["cep"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["telefone"].ToString(), dr["email"].ToString(), (byte[]) dr["foto"], int.Parse(dr["ativo"].ToString()));
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
            return al;  
        }

        public bool atualizar(Aluno al)
        {
            bool att = false;
            try
            {
                con = new Conexao().getConnection();
                con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE EstudioAluno SET nome = '{al.getSetNome}', endereco = '{al.getSetEndereco}', numero = '{al.getSetNumero}', bairro = '{al.getSetBairro}', complemento = '{al.getSetComplemento}', cep = '{al.getSetCep}', cidade = '{al.getSetCidade}', estado = '{al.getSetEstado}', telefone = '{al.getSetTelefone}', email = '{al.getSetEmail}', ativo = {al.getSetAtivo} WHERE cpf = '{al.getSetCpf}'", con);
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
    }
}
