using Dapper;
using Dapper_Example.Configs;
using Dapper_Example.Models;
using System.Data.SqlClient;

namespace Dapper_Example.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private string? _connectionString;

        public AirportRepository()
        {
            _connectionString = DataBaseConfiguration.Get();
        }

        public bool Add(Airport airport)
        {
            bool status = false;

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                connection.Execute(Airport.insertAirport, airport);
                status = true;
            }
            return status;
        }

        List<Airport> IAirportRepository.GetAll()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            var airports = connection.Query<Airport>(Airport.selectAllAirports).ToList();
            return (List<Airport>)airports;
        }
    }
}