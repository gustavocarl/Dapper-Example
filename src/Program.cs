using Dapper_Example.Models;
using Dapper_Example.Services;

Airport airport = new Airport()
{
    City = "São Paulo",
    Country = "Brasil",
    Code = "GRU",
    Continent = "América do Sul"
};

new AirportService().Add(airport);

foreach (var item in new AirportService().GetAll())
{
    Console.WriteLine(item);
}
