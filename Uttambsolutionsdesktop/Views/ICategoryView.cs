using System;
using System.Windows.Forms;
using DBL.Entities;

namespace Uttambsolutionsdesktop.Views
{
    public interface ICategoryView
    {
        // Properties
        int MainCategoryId { get; set; }
        string MainCategoryName { get; set; }
        // Properties
        int FirstCategoryId { get; set; }
        string FirstCategoryName { get; set; }
        int FirstMainCategoryId { get; set; }
        // Events
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveMainEvent;
        event EventHandler SaveFirstEvent;
        event EventHandler SaveThirdEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetMainCategoryListBindingSource(BindingSource categoryList);
        void SetFirstCategoryListBindingSource(BindingSource categoryList);
        void Show();
        void ShowMessage(string message);
    }
}
