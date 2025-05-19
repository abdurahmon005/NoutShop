using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoutShop.Services
{
     class DataBaseConnection
    {
        private readonly string _connectionString;

        public DataBaseConnection()
        {
            _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=abdurahmon7985;Database=noutshop";
        }

        public NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Ulanish muvaffaqiyatli!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ulanishda xatolik: " + ex.Message);
            }
            return connection;
        }
    }
}
