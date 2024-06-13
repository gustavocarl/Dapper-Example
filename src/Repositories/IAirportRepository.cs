using Dapper_Example.Models;

namespace Dapper_Example.Repositories
{
    public interface IAirportRepository
    {
        bool Add(Airport airport);

        List<Airport> GetAll();
    }
}