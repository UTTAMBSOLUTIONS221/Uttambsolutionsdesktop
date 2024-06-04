using DBL.Models;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DBL.Repositories
{
    public class SettingsRepository:BaseRepository, ISettingsRepository
    {
        public SettingsRepository(string connectionString) : base(connectionString)
        {
        }
        #region UOMS
        public IEnumerable<SystemUoms> GetAllSystemUoms()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch Uoms
                var uomQueryResult = connection.Query<SystemUoms>(
                    @"SELECT Uomid,UomName,UomSymbol FROM UnitOfMeasure");

                // Return the result
                return uomQueryResult;
            }
        }
        #endregion


        #region Tax Categories
        public IEnumerable<SystemTaxCategory> SystemTaxCategory()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch tax categories
                var taxCategoryQueryResult = connection.Query<SystemTaxCategory>(
                    @"SELECT Uomid,UomName,UomSymbol FROM UnitOfMeasure");

                // Return the result
                return taxCategoryQueryResult;
            }
        }
        #endregion
    }
}
