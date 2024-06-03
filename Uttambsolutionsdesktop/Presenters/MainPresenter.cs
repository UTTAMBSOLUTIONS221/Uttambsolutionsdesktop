using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class MainPresenter
    {
        private readonly IUserSettingsService _userSettingsService;
        private readonly IMainView _view;

        public MainPresenter(IUserSettingsService userSettingsService, IMainView view)
        {
            _userSettingsService = userSettingsService;
            _view = view;
            _view.HomeButtonClicked += OnHomeButtonClicked;
            _view.SettingsButtonClicked += OnSettingsButtonClicked;
        }

        private void OnHomeButtonClicked(object sender, EventArgs e)
        {
            // Handle Home button click
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Handle Settings button click
        }
    }
}
