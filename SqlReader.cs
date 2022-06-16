using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace PersonProject
{
    public class SqlReader
    {      // PAUSE TIL 13.27
        private string _connectionString { get; set; }
        public SqlReader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Person>> GetPeople()
        {
            List<Person> people = new List<Person>();
            var query = $"select * from Persons";
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
            var query = $"select * from Persons where WorkPlace like '{workplace}'";
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                people = connection.Query<Person>(query).ToList();
            }

            return people;
        }

        public async Task<List<Person>> GetEmployeees()
        {
            List<Person> people = new List<Person>();
            var query = $"Select * from Persons where WorkPlace is not null";
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                people = connection.Query<Person>(query).ToList();
            }

            return people;
        }



    }
}
