using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private String descricao;
        private double preco;
        private int qtdeAlunos;
        private int qtdeAulas;

        public Modalidade()
        {
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade(string descricao, double preco, int qtdeAlunos, int qtdeAulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtdeAlunos = qtdeAlunos;
            this.qtdeAulas = qtdeAulas;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int QtdeAulas { get => qtdeAulas; set => qtdeAulas = value; }
        public int QtdeAlunos { get => qtdeAlunos; set => qtdeAlunos = value; }

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAluno, qtdeAulas) values ('" + descricao + "'" +
                    ", "+ preco + ", " + qtdeAlunos + ", " + qtdeAulas + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
 
        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where ativa NOT IN (1)", DAO_Conexao.con); // ta funfando
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }
        public bool atualizarModalidade()
        {
            bool at = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualizar = new MySqlCommand("Update Estudio_Modalidade set precoModalidade = " + preco + ", qtdeAluno = " + qtdeAlunos + ", qtdeAulas = " + qtdeAulas + " where descricaoModalidade = '"+ descricao + "'", DAO_Conexao.con);
                atualizar.ExecuteNonQuery();
                at = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return at;
        }

        public bool excluirModalidade() {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
