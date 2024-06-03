﻿using System;
using System.Windows.Forms;
using DBL.Entities;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class CategoryPageForm : UserControl, ICategoryView
    {
        private CategoryPresenter _presenter;

        public CategoryPageForm()
        {
            InitializeComponent();
        }

        public void Initialize(CategoryPresenter presenter)
        {
            _presenter = presenter;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += (s, e) => SearchEvent?.Invoke(this, EventArgs.Empty);
            btnAddNew.Click += (s, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);
        }

        public string SearchText => txtSearch.Text;

        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridView.DataSource = categoryList;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
