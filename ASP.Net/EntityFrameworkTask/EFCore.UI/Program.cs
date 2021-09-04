using EFCore.Data;
using System;

namespace EFCore.UI
{
    internal class Program
    {
        private static DataContext _context;

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _context = new DataContext();
            _context.Database.EnsureCreated();
            Console.WriteLine("Bye World!");

            Console.ReadKey();
        }
    }
}