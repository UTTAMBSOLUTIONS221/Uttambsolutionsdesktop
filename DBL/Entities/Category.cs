using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class MainCategory
    {
        public int MainCategoryId { get; set; }
        public string? MainCategoryName { get; set; }
        public List<FirstCategory>? FirstCategories { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class FirstCategory
    {
        public int FirstCategoryId { get; set; }
        public string? FirstCategoryName { get; set; }
        public int MainCategoryId { get; set; }
        public string? MainCategoryName { get; set; }
        public List<ThirdCategory>? ThirdCategories { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class ThirdCategory
    {
        public int ThirdCategoryId { get; set; }
        public string? ThirdCategoryName { get; set; }
        public int FirstCategoryId { get; set; }
        public string? FirstCategoryName { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
