using System;
using System.Collections.Generic;
using DBL.Entities;

namespace Uttambsolutionsdesktop.Views
{
    public interface ICategoryView
    {
        string SearchText { get; }
        void SetCategoryListBindingSource(BindingSource categoryList);
        void ShowMessage(string message);

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
    }
}
