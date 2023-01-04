using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BookStore.Persistence
{
    public class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MySql");
            }
        }
    }
}