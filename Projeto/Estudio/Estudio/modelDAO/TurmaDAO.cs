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
    }
}
