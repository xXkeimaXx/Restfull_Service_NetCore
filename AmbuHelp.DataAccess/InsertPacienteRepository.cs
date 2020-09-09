using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System;

namespace AmbuHelp.DataAccess
{
    public class InsertPacienteRepository : Repository<InsertPacientes>, IInsertPacienteRepository
    {
        public InsertPacienteRepository(string connectionString) : base(connectionString)
        {
        }

        public InsertPacientes uspInsertPaciente(string userName, 
                                                 string password, 
                                                 string nombres, 
                                                 string apPaterno, 
                                                 string apMaterno, 
                                                 string docId, 
                                                 int ubigeo, 
                                                 string direccion, 
                                                 string numCelular, 
                                                 string correoPer, 
                                                 string coPariente, 
                                                 DateTime fechaNac)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_UserName", userName);
            parameters.Add("_Password", password);
            parameters.Add("_Nombres", nombres);
            parameters.Add("_ApPaterno", apPaterno);
            parameters.Add("_ApMaterno", apMaterno);
            parameters.Add("_DocId", docId);
            parameters.Add("_Ubigeo", ubigeo);
            parameters.Add("_Direccion", direccion);
            parameters.Add("_NumCelular", numCelular);
            parameters.Add("_CorreoPer", correoPer);
            parameters.Add("_CoPariente", coPariente);
            parameters.Add("_FechaNac", fechaNac);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<InsertPacientes>(
                    "uspInsertPaciente", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
