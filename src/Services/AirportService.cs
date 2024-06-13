using Dapper_Example.Models;
using Dapper_Example.Repositories;

namespace Dapper_Example.Services
{
    public class AirportService
    {
        private IAirportRepository _airportRepository;

        public AirportService()
        {
            _airportRepository = new AirportRepository();
        }

        public bool Add(Airport airport)
        {
            return _airportRepository.Add(airport);
        }

        public List<Airport> GetAll()
        {
            return _airportRepository.GetAll();
        }
    }
}