using EFCore.Data;
using EFCore.Data.Repo;
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
            using (var unitOfWork = new UnitOfWork(_context))
            {
                var sortedProducts = unitOfWork.Products.SortByPrice();
                foreach (var product in sortedProducts)
                {
                    Console.WriteLine(product);
                }
                unitOfWork.Products.RemoveRange(sortedProducts); //
            }
                
                Console.ReadKey();
        }
    }
}
