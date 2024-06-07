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
                var productQueryResult = connection.Query<SystemProductData>(@"SELECT a.ProductId,a.ProductName AS Product,a.UomId,c.UomName AS Uom,a.BrandId,b.ProductBrandName AS Brand,a.MainCategoryId,d.MainCategoryName AS MainCategory,a.FirstCategoryId,e.FirstCategoryName AS FirstCategory,a.TaxCategoryId,g.TaxValue AS TaxCategoryValue,f.TaxCategoryName AS TaxCategory,a.Barcode,a.ProductUnits AS Units,a.WholeSalePrice,a.RetailSalePrice,a.ProfitMargin,a.ProductSize,a.ProductColor,a.ProductWeight,h.FirstName || ' ' || h.LastName AS Createdby,i.FirstName || ' ' || i.LastName AS Modifiedby,a.Datecreated,a.Datemodified FROM Product a INNER JOIN ProductBrand b ON a.BrandId=b.ProductBrandId INNER JOIN UnitOfMeasure c ON a.UomId=c.UomId INNER JOIN MainCategory d ON a.MainCategoryId=d.MainCategoryId INNER JOIN FirstCategory e ON a.FirstCategoryId=e.FirstCategoryId INNER JOIN TaxCategory f ON a.TaxCategoryId=f.TaxCategoryId INNER JOIN TaxCategoryValues g ON a.TaxCategoryId=g.TaxCategoryId INNER JOIN SystemStaffs h ON a.Createdby=h.Userid INNER JOIN SystemStaffs i ON a.Modifiedby=i.Userid");

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
                var productQueryResult = connection.Query<SystemProductData>(@"SELECT a.ProductId,a.ProductName AS Product,a.UomId,c.UomName AS Uom,a.BrandId,b.ProductBrandName AS Brand,a.MainCategoryId,d.MainCategoryName AS MainCategory,a.FirstCategoryId,e.FirstCategoryName AS FirstCategory,a.TaxCategoryId,g.TaxValue AS TaxCategoryValue,f.TaxCategoryName AS TaxCategory,a.Barcode,a.ProductUnits AS Units,a.WholeSalePrice,a.RetailSalePrice,a.ProfitMargin,a.ProductSize,a.ProductColor,a.ProductWeight,h.FirstName || ' ' || h.LastName AS Createdby,i.FirstName || ' ' || i.LastName AS Modifiedby,a.Datecreated,a.Datemodified FROM Product a INNER JOIN ProductBrand b ON a.BrandId=b.ProductBrandId INNER JOIN UnitOfMeasure c ON a.UomId=c.UomId INNER JOIN MainCategory d ON a.MainCategoryId=d.MainCategoryId INNER JOIN FirstCategory e ON a.FirstCategoryId=e.FirstCategoryId INNER JOIN TaxCategory f ON a.TaxCategoryId=f.TaxCategoryId INNER JOIN TaxCategoryValues g ON a.TaxCategoryId=g.TaxCategoryId INNER JOIN SystemStaffs h ON a.Createdby=h.Userid INNER JOIN SystemStaffs i ON a.Modifiedby=i.Userid WHERE a.Barcode LIKE '%' || @searchValue || '%' OR a.ProductName LIKE '%' || @searchValue || '%'", new { searchValue });


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


        #region Product Orders
        public Genericmodel SaveCustomerOrder(CustomerOrder entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert the order into the database
                        var orderId = connection.ExecuteScalar<int>(
                            @"INSERT INTO CustomerOrder (OrderCode, OrderGrossTotal, OrderNetTotal, OrderVatTotal, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@OrderCode, @OrderGrossTotal, @OrderNetTotal, @OrderVatTotal, @Createdby, @Modifiedby, @DateCreated, @DateModified);
                  SELECT last_insert_rowid();",
                            new
                            {
                                entity.OrderCode,
                                entity.OrderGrossTotal,
                                entity.OrderNetTotal,
                                entity.OrderVatTotal,
                                entity.Createdby,
                                entity.Modifiedby,
                                entity.DateCreated,
                                entity.DateModified
                            }, transaction);

                        // Insert the order items into the database
                        foreach (var item in entity.OrderItems)
                        {
                            connection.Execute(
                                @"INSERT INTO CustomerOrderItems (OrderId, ProductId, ProductPrice, ProductVat, ProductUnits, ItemGrossTotal, ItemNetTotal, ItemVatTotal, Createdby, Modifiedby, DateCreated, DateModified) 
                      VALUES (@OrderId, @ProductId, @ProductPrice, @ProductVat, @ProductUnits, @ItemGrossTotal, @ItemNetTotal, @ItemVatTotal, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                                new
                                {
                                    OrderId = orderId,
                                    item.ProductId,
                                    item.ProductPrice,
                                    item.ProductVat,
                                    item.ProductUnits,
                                    item.ItemGrossTotal,
                                    item.ItemNetTotal,
                                    item.ItemVatTotal,
                                    item.Createdby,
                                    item.Modifiedby,
                                    item.DateCreated,
                                    item.DateModified
                                }, transaction);
                        }

                        transaction.Commit();

                        // Return the inserted orderId
                        return new Genericmodel { RespStatus = 0, RespMessage = "Order and Items Added Successfully", Data1 = orderId.ToString() };
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return new Genericmodel { RespStatus = 2, RespMessage = $"Error Occurred: {ex.Message}" };
                    }
                }
            }
        }

        public CustomerOrder GetSaleProductsByOrderId(int OrderId)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch categories
                var queryResult = connection.Query<dynamic>(@"
            SELECT 
                co.OrderId,
                co.OrderCode,
                co.OrderGrossTotal,
                co.OrderNetTotal,
                co.OrderVatTotal,
                co.Createdby,
                co.Modifiedby,
                co.DateCreated,
                co.DateModified,
                json_group_array(
                    json_object(
                        'OrderItemId', coi.OrderItemId,
                        'ProductId', coi.ProductId,
                        'ProductPrice', coi.ProductPrice,
                        'ProductVat', coi.ProductVat,
                        'ProductUnits', coi.ProductUnits,
                        'ItemGrossTotal', coi.ItemGrossTotal,
                        'ItemNetTotal', coi.ItemNetTotal,
                        'ItemVatTotal', coi.ItemVatTotal,
                        'Createdby', coi.Createdby,
                        'Modifiedby', coi.Modifiedby,
                        'DateCreated', coi.DateCreated,
                        'DateModified', coi.DateModified
                    )
                ) AS OrderItems
            FROM CustomerOrder co
            LEFT JOIN CustomerOrderItems coi ON co.OrderId = coi.OrderId
            WHERE co.OrderId = @OrderId;
        ", new { OrderId });

                // Map the query result to CustomerOrder object
                if (queryResult != null && queryResult.Any())
                {
                    var result = queryResult.First();
                    var order = new CustomerOrder
                    {
                        OrderId = result.OrderId,
                        OrderCode = result.OrderCode,
                        OrderGrossTotal = result.OrderGrossTotal,
                        OrderNetTotal = result.OrderNetTotal,
                        OrderVatTotal = result.OrderVatTotal,
                        Createdby = result.Createdby,
                        Modifiedby = result.Modifiedby,
                        DateCreated = result.DateCreated,
                        DateModified = result.DateModified,
                        OrderItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CustomerOrderItems>>(result.OrderItems)
                    };
                    return order;
                }

                // If no result found, return null
                return null;
            }
        }


        #endregion

    }
}
