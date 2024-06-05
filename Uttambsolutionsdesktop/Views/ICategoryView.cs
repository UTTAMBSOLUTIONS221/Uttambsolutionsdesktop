using System;
using System.Windows.Forms;
using DBL.Entities;

namespace Uttambsolutionsdesktop.Views
{
    public interface ICategoryView
    {
        // Properties
        int CategoryId { get; set; }
        string CategoryName { get; set; }

        // Events
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetMainCategoryListBindingSource(BindingSource categoryList);
        void SetFirstCategoryListBindingSource(BindingSource categoryList);
        void SetThirdCategoryListBindingSource(BindingSource categoryList);
        void Show();
        void ShowMessage(string message);
    }
}
