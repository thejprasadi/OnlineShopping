using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace OnlineShopping.DataAccess.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(),"appsettings.json");
            configBuilder.AddJsonFile(path, false);// get the actual settings from the appsettings
            var root = configBuilder.Build();
            var appsetting=root.GetSection("ConnectionStrings:DefaultConnectionString");
            sqlConnectionString = appsetting.Value;


        }
        public string sqlConnectionString { get; set; }
    }
}
