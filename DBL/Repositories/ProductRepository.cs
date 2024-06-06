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
                    @"SELECT a.ProductId,a.ProductName AS Product,a.UomId,b.UomName AS Uom,a.BrandId,e.ProductBrandName AS Brand,a.MainCategoryId,c.MainCategoryName AS MainCategory,a.FirstCategoryId,d.FirstCategoryName AS FirstCategory,a.TaxCategoryId,d.TaxCategoryName AS TaxCategory,a.Barcode,a.ProductUnits AS Units,a.WholeSalePrice,a.RetailSalePrice,a.ProfitMargin,a.ProductSize,a.ProductColor,a.ProductWeight,e.FirstName || ' ' || e.LastName AS Createdby,f.FirstName || ' ' || f.LastName AS Modifiedby,a.Datecreated,a.Datemodified FROM Product a INNER JOIN ProductBrand e ON a.BrandId=e.ProductBrandId INNER JOIN UnitOfMeasure b ON a.UomId=b.UomId INNER JOIN MainCategory c ON a.MainCategoryId=c.MainCategoryId INNER JOIN FirstCategory d ON a.FirstCategoryId=d.FirstCategoryId INNER JOIN TaxCategory d ON a.TaxCategoryId=d.TaxCategoryId INNER JOIN SystemStaffs e ON a.Createdby=e.Userid INNER JOIN SystemStaffs f ON a.Modifiedby=f.Userid");

                // Return the result
                return productQueryResult;
            }
        }
        public IEnumerable<SystemProductData> GetProductsByValue(string searchValue)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var productQueryResult = connection.Query<SystemProductData>(
                    @"SELECT a.ProductId,a.ProductName AS Product,a.UomId,b.UomName AS Uom,a.BrandId,e.ProductBrandName AS Brand,a.MainCategoryId,c.MainCategoryName AS MainCategory,a.FirstCategoryId,d.FirstCategoryName AS FirstCategory,a.TaxCategoryId,d.TaxCategoryName AS TaxCategory,a.Barcode,a.ProductUnits AS Units,a.WholeSalePrice,a.RetailSalePrice,a.ProfitMargin,a.ProductSize,a.ProductColor,a.ProductWeight,e.FirstName || ' ' || e.LastName AS Createdby,f.FirstName || ' ' || f.LastName AS Modifiedby,a.Datecreated,a.Datemodified FROM Product a INNER JOIN ProductBrand e ON a.BrandId=e.ProductBrandId INNER JOIN UnitOfMeasure b ON a.UomId=b.UomId INNER JOIN MainCategory c ON a.MainCategoryId=c.MainCategoryId INNER JOIN FirstCategory d ON a.FirstCategoryId=d.FirstCategoryId INNER JOIN TaxCategory d ON a.TaxCategoryId=d.TaxCategoryId INNER JOIN SystemStaffs e ON a.Createdby=e.Userid INNER JOIN SystemStaffs f ON a.Modifiedby=f.Userid WHERE a.Barcode = @SearchValue OR a.ProductName LIKE '%' || @SearchValue || '%'");

                // Return the result
                return productQueryResult;
            }
        }

        public Genericmodel SaveProduct(SystemProduct entity)
        {
            // Validate the data
            if (string.IsNullOrWhiteSpace(entity.ProductName))
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Product Name cannot be empty" };
            }

            if (entity.UomId <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Please select a valid Unit of Measure (UOM)" };
            }

            if (entity.MainCategoryId <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Please select a valid Main Category" };
            }

            if (entity.FirstCategoryId <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Please select a valid First Category" };
            }

            if (entity.BrandId <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Please select a valid Brand" };
            }

            if (entity.TaxCategoryId <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Please select a valid Tax Category" };
            }

            if (entity.WholeSalePrice < 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Wholesale Price cannot be negative" };
            }

            if (entity.RetailSalePrice < 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Retail Sale Price cannot be negative" };
            }

            if (entity.ProductUnits <= 0)
            {
                return new Genericmodel { RespStatus = 1, RespMessage = "Product Units must be greater than zero" };
            }
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
                      MainCategoryId = @MainCategoryId,
                      FirstCategoryId = @FirstCategoryId,
                      BrandId = @BrandId,
                      TaxCategoryId = @TaxCategoryId,
                      Barcode = @Barcode,
                      ProductUnits = @ProductUnits,
                      WholeSalePrice = @WholeSalePrice,
                      RetailSalePrice = @RetailSalePrice,
                      ProfitMargin = @ProfitMargin,
                      ProductSize = @ProductSize,
                      ProductColor = @ProductColor,
                      ProductWeight = @ProductWeight,
                      Modifiedby = @Modifiedby,
                      DateModified = @DateModified 
                  WHERE ProductId = @ProductId",
                        new
                        {
                            entity.ProductName,
                            entity.UomId,
                            entity.MainCategoryId,
                            entity.FirstCategoryId,
                            entity.BrandId,
                            entity.TaxCategoryId,
                            entity.Barcode,
                            entity.ProductUnits,
                            entity.WholeSalePrice,
                            entity.RetailSalePrice,
                            entity.ProfitMargin,
                            entity.ProductSize,
                            entity.ProductColor,
                            entity.ProductWeight,
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.ProductId
                        });

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
                        // Product already exists, return failure
                        return new Genericmodel { RespStatus = 1, RespMessage = "Product Name Already Exists" };
                    }

                    // Insert the product into the database
                    var result = connection.Execute(
                        @"INSERT INTO Product (ProductName, UomId, MainCategoryId, FirstCategoryId, BrandId, TaxCategoryId, Barcode, ProductUnits, WholeSalePrice, RetailSalePrice, ProfitMargin, ProductSize, ProductColor, ProductWeight, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@ProductName, @UomId, @MainCategoryId, @FirstCategoryId, @BrandId, @TaxCategoryId, @Barcode, @ProductUnits, @WholeSalePrice, @RetailSalePrice, @ProfitMargin, @ProductSize, @ProductColor, @ProductWeight, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.ProductName,
                            entity.UomId,
                            entity.MainCategoryId,
                            entity.FirstCategoryId,
                            entity.BrandId,
                            entity.TaxCategoryId,
                            entity.Barcode,
                            entity.ProductUnits,
                            entity.WholeSalePrice,
                            entity.RetailSalePrice,
                            entity.ProfitMargin,
                            entity.ProductSize,
                            entity.ProductColor,
                            entity.ProductWeight,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Product Added Successfully" };
                }
            }
        }
    }
}
