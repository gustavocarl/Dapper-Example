namespace Dapper_Example.Models
{
    public class Airport
    {
        public static readonly string insertAirport = "INSERT INTO LOCATIONS ( " +
            "CITY, COUNTRY, CODE, CONTINENT " +
            ") VALUES ( " +
            "@CITY, @COUNTRY, @CODE, @CONTINENT " +
            ") ";

        public static readonly string selectAllAirports = "SELECT " +
            "ID, CITY, COUNTRY, CODE, CONTINENT " +
            "FROM LOCATIONS ";

        public int Id { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? Code { get; set; }

        public string? Continent { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                $"Cidade: {City}\n" +
                $"País: {Country}\n" +
                $"Código: {Code}\n" +
                $"Continente: {Continent}\n";
        }
    }
}