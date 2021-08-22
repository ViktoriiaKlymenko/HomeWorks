using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using DapperTask.Data;
using Dapper;

namespace DapperTask.Repo
{
    public class Repository
    {
        private IDbConnection db;

        public Repository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

        public Product GetProductById(int id)
        {
            var sql ="SELECT * FROM Products WHERE Id = @Id";
            return db.Query<Product>(sql, new { Id = id }).SingleOrDefault();
        }
        public int AddProduct()
        {
            throw new NotImplementedException();
        }
        public int DeleteProduct()
        {
            throw new NotImplementedException();
        }
    }
}
