using System;
using Microsoft.Extensions.Configuration;

namespace SqlDependencyHelper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json", true, true)
                .Build();

            string connectionString = config["connectionString"];
            SqlDependencyService service = new SqlDependencyService(connectionString);
            service.CreateObjects();
            Console.WriteLine("Finished");
        }
    }
}
