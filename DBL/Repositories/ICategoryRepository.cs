using DBL.Entities;
using DBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<SystemProductBrand> GetAllProductBrands();
        Genericmodel SaveProductBrand(SystemProductBrand entity);
        IEnumerable<MainCategory> GetAllMainCategories();
        IEnumerable<FirstCategory> GetAllFirstCategories();
        IEnumerable<ThirdCategory> GetAllThirdCategories();
        Genericmodel SaveMainCategory(MainCategory entity);
        Genericmodel SaveFirstCategory(FirstCategory entity);
        Genericmodel SaveThirdCategory(ThirdCategory entity);
    }
}
