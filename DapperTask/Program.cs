using DapperTask.Repo;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DapperTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var configuration = Initialize();

            var repository = new Repository(configuration.GetConnectionString("ConnectionString"));

            var some = repository.GetProductById(1);
            Console.WriteLine(some.Name);
            Console.ReadKey();
        }
        private static IConfiguration Initialize()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
