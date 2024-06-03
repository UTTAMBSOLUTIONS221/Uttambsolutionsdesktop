using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Presenters;

namespace Uttambsolutionsdesktop.Views
{
    public interface ICategoryView
    {
        void DisplayCategories(List<Category> categories);
    }
}
