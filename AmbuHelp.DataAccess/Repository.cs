using AmbuHelp.Repositories;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;
        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
            _connectionString = connectionString;
        }
        public bool Delete(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        public T GetById(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int insert(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}
