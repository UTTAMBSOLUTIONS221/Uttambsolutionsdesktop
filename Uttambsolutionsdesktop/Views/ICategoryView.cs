using System;
using System.Collections.Generic;
using DBL.Entities;

namespace Uttambsolutionsdesktop.Views
{
    public interface ICategoryView
    {
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetCategoryListBindingSource(BindingSource categoryList);
        void Show();
    }
}
