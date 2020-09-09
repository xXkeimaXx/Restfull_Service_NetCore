using AmbuHelp.Models;
using AmbuHelp.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Ah_TipoSolicitudRepository : Repository<Ah_TipoSolicitud>, IAh_TipoSolicitudRepository
    {
        public Ah_TipoSolicitudRepository(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<Ah_TipoSolicitud> uspGetList(string Option)
        {
            List < Ah_TipoSolicitud > lista = new List<Ah_TipoSolicitud>();
            Ah_TipoSolicitud ah_Tipo = null;

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
                    ah_Tipo = new Ah_TipoSolicitud();
                    ah_Tipo.IdTipoSolicitud = Convert.ToInt32(reader["IdTipoSolicitud"].ToString());
                    ah_Tipo.TipoSol = reader["TipoSol"].ToString();

                    lista.Add(ah_Tipo);
                }

            }

            return lista;
        }


    }
}
