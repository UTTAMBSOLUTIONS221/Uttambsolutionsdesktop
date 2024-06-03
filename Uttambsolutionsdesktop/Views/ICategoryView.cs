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
        string SearchValue { get; }
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCategoryListBindingSource(object dataSource);
        void Show();
    }
}
