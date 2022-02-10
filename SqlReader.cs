using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace PersonProject
{
    public class SqlReader
    {      
        private string _connectionString { get; set; }
        public SqlReader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Person>> GetPeople()
        {
            List<Person> people = new List<Person>();
            var query = $"select * from Person";
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                people = connection.Query<Person>(query).ToList();
            }

            return people;
        }

        public async Task<List<Person>> GetEmployeees(string workplace)
        {
            List<Person> people = new List<Person>();
            var query = $"select * from Person where WorkPlace like '{workplace}'";
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                people = connection.Query<Person>(query).ToList();
            }

            return people;
        }


    }
}
