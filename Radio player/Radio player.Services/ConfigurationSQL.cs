
using Microsoft.Extensions.Configuration;

namespace Radio_player.Services
{
    static class ConfigurationSQL
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Radio_player.WebAPI"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SQL");
            }
        }
    }
}
