﻿using DBL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Uttambsolutionsdesktop.Program;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class SystemStaffForm : UserControl, IStaffView
    {
        private StaffPresenter _presenter;
        private readonly string _userId;

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Properties
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public int Userid
        {
            get { return int.TryParse(txtUserId.Text, out int id) ? id : 0; }
            set { txtUserId.Text = value.ToString(); }
        }

        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string Phonenumber
        {
            get { return txtPhonenumber.Text; }
            set { txtPhonenumber.Text = value; }
        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Emailaddress
        {
            get { return txtEmailaddress.Text; }
            set { txtEmailaddress.Text = value; }
        }

        public int Roleid
        {
            get { return int.TryParse(txtRoleid.Text, out int id) ? id : 0; }
            set { txtRoleid.Text = value.ToString(); }
        }

        public void SetStaffListBindingSource(BindingSource staffList)
        {
            dataGridView.DataSource = staffList;
            // Ensure the hidden UserId column is added
            if (!dataGridView.Columns.Contains("UserId"))
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "UserId",
                    HeaderText = "UserId",
                    DataPropertyName = "UserId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }

        public SystemStaffForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new StaffPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageStaffDetail);
            // Subscribe to the DataBindingComplete event
            dataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                Userid = 0; // Ensure UserId is set to 0 for new entries
                tabControl1.TabPages.Remove(tabPageStaffList);
                tabControl1.TabPages.Add(tabPageStaffDetail);
                tabPageStaffDetail.Text = "Add New Staff";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                    if (selectedRow.Cells["Userid"].Value != null &&
                        selectedRow.Cells["FirstName"].Value != null &&
                        selectedRow.Cells["LastName"].Value != null &&
                        selectedRow.Cells["Phonenumber"].Value != null &&
                        selectedRow.Cells["Username"].Value != null &&
                        selectedRow.Cells["Emailaddress"].Value != null &&
                        selectedRow.Cells["Roleid"].Value != null)
                    {
                        Userid = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                        FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                        LastName = selectedRow.Cells["LastName"].Value.ToString();
                        Phonenumber = selectedRow.Cells["Phonenumber"].Value.ToString();
                        Username = selectedRow.Cells["Username"].Value.ToString();
                        Emailaddress = selectedRow.Cells["Emailaddress"].Value.ToString();
                        Roleid = Convert.ToInt32(selectedRow.Cells["RoleId"].Value);
                    }
                }
                tabControl1.TabPages.Remove(tabPageStaffList);
                tabControl1.TabPages.Add(tabPageStaffDetail);
                tabPageStaffDetail.Text = "Edit Staff";
            };

            // CellClick event handler to select the entire row
            dataGridView.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridView.Rows[e.RowIndex].Selected = true;
                }
            };

            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageStaffDetail);
                tabControl1.TabPages.Add(tabPageStaffList);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                tabControl1.TabPages.Remove(tabPageStaffDetail);
                tabControl1.TabPages.Add(tabPageStaffList);
            };
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns.Contains("UserId"))
            {
                dataGridView.Columns["UserId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Createdby"))
            {
                dataGridView.Columns["Createdby"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Modifiedby"))
            {
                dataGridView.Columns["Modifiedby"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Datecreated"))
            {
                dataGridView.Columns["Datecreated"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Datemodified"))
            {
                dataGridView.Columns["Datemodified"].Visible = false;
            }
        }

        // Method to clear the detail fields
        private void ClearDetailFields()
        {
            Userid = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Phonenumber = string.Empty;
            Username = string.Empty;
            Emailaddress = string.Empty;
            Roleid = 0;
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
