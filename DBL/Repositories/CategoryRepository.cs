﻿using Dapper;
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
                    @"SELECT CategoryId,CategoryName FROM Categories");

                // Return the result
                return categoryQueryResult;
            }
        }

        public Genericmodel SaveCategory(Category entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                if (entity.CategoryId>0)
                {
                    // Update the category
                    var result = connection.Execute(
                        @"UPDATE Categories 
                  SET CategoryName = @CategoryName, Modifiedby = @Modifiedby, 
                      DateModified = @DateModified 
                  WHERE CategoryId = @CategoryId",
                        new
                        {
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.CategoryName,
                            entity.CategoryId
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Category Updated Successfully" };
                }
                else
                {

                    // Check if the category already exists
                    var categoryExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM Categories WHERE CategoryName = @CategoryName",
                        new { CategoryName = entity.CategoryName });

                    if (categoryExists)
                    {
                        // Category already exists, return 0 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "Category Exists" };
                    }

                    // Insert the category into the database
                    var result = connection.Execute(
                        @"INSERT INTO Categories (CategoryName, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@CategoryName, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.CategoryName,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Category Added Successfully" };
                }
            }
        }
    }
}
