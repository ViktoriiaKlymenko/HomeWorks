using EFCore.Data;
using System;

namespace EFCore.UI
{
    class Program
    {
        private static DataContext _context;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _context = new DataContext();
            _context.Database.EnsureCreated();
            Console.WriteLine("Bye World!");
            Console.ReadKey();
        }
    }
}
