using AmbuHelp.Models;
using AmbuHelp.Repositories;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Ah_TipoEmergenciaRepository : Repository<Ah_TipoEmergencia>, IAh_TipoEmergenciaRepository
    {
        public Ah_TipoEmergenciaRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<Ah_TipoEmergencia> uspGetList(string Option)
        {
            List<Ah_TipoEmergencia> lista = new List<Ah_TipoEmergencia>();
            Ah_TipoEmergencia ah_Tipo = null;

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                comando.CommandText = @"uspGetList";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new MySqlParameter("_Option", Option));
                comando.Parameters.Add(new MySqlParameter("_IdCent", ""));

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ah_Tipo = new Ah_TipoEmergencia();
                    ah_Tipo.IdTipoEmergencia = reader["IdTipoEmergencia"].ToString();
                    ah_Tipo.DesTipo = reader["DesTipo"].ToString();

                    lista.Add(ah_Tipo);
                }

            }

            return lista;
        }
    }
}
