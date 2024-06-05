using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Views
{
    public interface IStaffView
    {  // Properties
        string SearchValue { get; set; }

        // Properties from SystemStaff
        int Userid { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? Phonenumber { get; set; }
        string? Username { get; set; }
        string? Emailaddress { get; set; }
        int Roleid { get; set; }
        
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetStaffListBindingSource(BindingSource staffList);
        void Show();
    }
}
