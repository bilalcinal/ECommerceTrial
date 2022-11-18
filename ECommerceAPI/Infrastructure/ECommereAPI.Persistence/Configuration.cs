using Microsoft.Extensions.Configuration;

namespace ECommereAPI.Persistence
{
     static public class Configuration
    {
        static public string ConnectionString
        {
             get
             {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/ECommerceAPI.API"));
                configurationManager.AddJsonFile("appsettings.json"); 
                return configurationManager.GetConnectionString("PostgreSQL");
             }
        }
    }
}