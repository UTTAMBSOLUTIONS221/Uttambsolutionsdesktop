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
        public IEnumerable<MainCategory> GetAllMainCategories()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var categoryMainQueryResult = connection.Query<MainCategory>(
                    @"SELECT MainCategoryId,MainCategoryName FROM MainCategory");

                // Return the result
                return categoryMainQueryResult;
            }
        }
        public IEnumerable<FirstCategory> GetAllFirstCategories()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var categoryFirstQueryResult = connection.Query<FirstCategory>(
                    @"SELECT FirstCategoryId,FirstCategoryName,a.MainCategoryId,MainCategoryName FROM FirstCategory a INNER JOIN MainCategory b ON a.MainCategoryId = b.MainCategoryId");

                // Return the result
                return categoryFirstQueryResult;
            }
        }
        public IEnumerable<ThirdCategory> GetAllThirdCategories()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var categoryThirdQueryResult = connection.Query<ThirdCategory>(
                    @"SELECT ThirdCategoryId,ThirdCategoryName,a.FirstCategoryId,FirstCategoryName FROM ThirdCategory a INNER JOIN FirstCategory b ON a.FirstCategoryId=b.FirstCategoryId");

                // Return the result
                return categoryThirdQueryResult;
            }
        }

        public Genericmodel SaveMainCategory(MainCategory entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                if (entity.MainCategoryId > 0)
                {
                    // Update the main category
                    var result = connection.Execute(
                        @"UPDATE MainCategory 
                  SET MainCategoryName = @MainCategoryName, Modifiedby = @Modifiedby, 
                      DateModified = @DateModified 
                  WHERE MainCategoryId = @MainCategoryId",
                        new
                        {
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.MainCategoryName,
                            entity.MainCategoryId
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Main Category Updated Successfully" };
                }
                else
                {
                    // Check if the main category already exists
                    var categoryExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM MainCategory WHERE MainCategoryName = @MainCategoryName",
                        new { MainCategoryName = entity.MainCategoryName });

                    if (categoryExists)
                    {
                        // Main category already exists, return 0 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "Main Category Exists" };
                    }

                    // Insert the main category into the database
                    var result = connection.Execute(
                        @"INSERT INTO MainCategory (MainCategoryName, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@MainCategoryName, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.MainCategoryName,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Main Category Added Successfully" };
                }
            }
        }

        public Genericmodel SaveFirstCategory(FirstCategory entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();
                if (entity.FirstCategoryId > 0)
                {
                    // Update the first category
                    var result = connection.Execute(
                        @"UPDATE FirstCategory 
                  SET FirstCategoryName = @FirstCategoryName, Modifiedby = @Modifiedby, 
                      DateModified = @DateModified 
                  WHERE FirstCategoryId = @FirstCategoryId",
                        new
                        {
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.FirstCategoryName,
                            entity.FirstCategoryId
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "First Category Updated Successfully" };
                }
                else
                {
                    // Check if the first category already exists
                    var categoryExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM FirstCategory WHERE FirstCategoryName = @FirstCategoryName",
                        new { FirstCategoryName = entity.FirstCategoryName });

                    if (categoryExists)
                    {
                        // First category already exists, return 0 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "First Category Exists" };
                    }

                    // Insert the first category into the database
                    var result = connection.Execute(
                        @"INSERT INTO FirstCategory (FirstCategoryName, MainCategoryId, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@FirstCategoryName, @MainCategoryId, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.FirstCategoryName,
                            entity.MainCategoryId,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "First Category Added Successfully" };
                }
            }
        }
        public Genericmodel SaveThirdCategory(ThirdCategory entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                if (entity.ThirdCategoryId > 0)
                {
                    // Update the third category
                    var result = connection.Execute(
                        @"UPDATE ThirdCategory 
                  SET ThirdCategoryName = @ThirdCategoryName, Modifiedby = @Modifiedby, 
                      DateModified = @DateModified 
                  WHERE ThirdCategoryId = @ThirdCategoryId",
                        new
                        {
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.ThirdCategoryName,
                            entity.ThirdCategoryId
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Third Category Updated Successfully" };
                }
                else
                {
                    // Check if the third category already exists
                    var categoryExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM ThirdCategory WHERE ThirdCategoryName = @ThirdCategoryName",
                        new { ThirdCategoryName = entity.ThirdCategoryName });

                    if (categoryExists)
                    {
                        // Third category already exists, return 0 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "Third Category Exists" };
                    }

                    // Insert the third category into the database
                    var result = connection.Execute(
                        @"INSERT INTO ThirdCategory (ThirdCategoryName, FirstCategoryId, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@ThirdCategoryName, @FirstCategoryId, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.ThirdCategoryName,
                            entity.FirstCategoryId,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Third Category Added Successfully" };
                }
            }
        }
    }
}
