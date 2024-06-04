using Dapper;
using DBL.Entities;
using DBL.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<CategoryData> GetAllCategories()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var categoryQueryResult = connection.Query<CategoryData>(
                    @"SELECT CategoryName FROM Categories");

                // Return the result
                return categoryQueryResult;
            }
        }



    }
}
