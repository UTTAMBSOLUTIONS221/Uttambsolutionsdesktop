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
    public class ProductRepository:BaseRepository,IProductRepository
    {
        public ProductRepository(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<SystemProductData> GetAllProducts()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var productQueryResult = connection.Query<SystemProductData>(
                    @"SELECT a.ProductId,a.ProductName,a.UomId,b.UomName,a.CategoryId,c.CategoryName,a.TaxCategoryId,d.TaxCategoryName,a.Barcode,a.Units,a.Price, e.FirstName || ' ' || e.LastName AS Createdby,f.FirstName || ' ' || f.LastName AS Modifiedby,a.Datecreated,a.Datemodified FROM Product a INNER JOIN UnitOfMeasure b ON a.UomId=b.UomId INNER JOIN Categories c ON a.CategoryId=c.CategoryId INNER JOIN TaxCategory d ON a.TaxCategoryId=d.TaxCategoryId INNER JOIN SystemStaffs e ON a.Createdby=e.Userid INNER JOIN SystemStaffs f ON a.Modifiedby=f.Userid");

                // Return the result
                return productQueryResult;
            }
        }

        public Genericmodel SaveProduct(SystemProduct entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                if (entity.ProductId > 0)
                {
                    // Update the product
                    var result = connection.Execute(
                        @"UPDATE Product 
                SET ProductName = @ProductName, 
                    UomId = @UomId,
                    CategoryId = @CategoryId,
                    TaxCategoryId = @TaxCategoryId,
                    Barcode = @Barcode,
                    Units = @Units,
                    Price = @Price,
                    ModifiedBy = @ModifiedBy,
                    DateModified = @DateModified 
                WHERE ProductId = @ProductId",
                        entity);

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Product Updated Successfully" };
                }
                else
                {
                    // Check if the product name already exists
                    var productExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM Product WHERE ProductName = @ProductName",
                        new { ProductName = entity.ProductName });

                    if (productExists)
                    {
                        // Product already exists, return 1 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "Product Name Already Exists" };
                    }

                    // Insert the product into the database
                    var result = connection.Execute(
                        @"INSERT INTO Product (ProductName, UomId, CategoryId, TaxCategoryId, Barcode, Units, Price, CreatedBy, ModifiedBy, DateCreated, DateModified) 
                VALUES (@ProductName, @UomId, @CategoryId, @TaxCategoryId, @Barcode, @Units, @Price, @CreatedBy, @ModifiedBy, @DateCreated, @DateModified)",
                        entity);

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Product Added Successfully" };
                }
            }
        }

    }
}
