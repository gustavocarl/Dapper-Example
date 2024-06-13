using Microsoft.Extensions.Configuration;

namespace Dapper_Example.Configs
{
    public class DataBaseConfiguration
    {
        public static IConfigurationRoot? Configuration { get; set; }

        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"]!;

            return connectionString;
        }
    }
}