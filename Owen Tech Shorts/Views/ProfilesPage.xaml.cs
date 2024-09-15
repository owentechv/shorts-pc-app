using System;

using Owen_Tech_Shorts.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Owen_Tech_Shorts.Views
{
    public sealed partial class ProfilesPage : Page
    {
        public ProfilesViewModel ViewModel { get; } = new ProfilesViewModel();

        public ProfilesPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
