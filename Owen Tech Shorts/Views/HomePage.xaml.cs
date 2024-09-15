using System;

using Owen_Tech_Shorts.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Owen_Tech_Shorts.Views
{
    public sealed partial class HomePage : Page
    {
        public HomeViewModel ViewModel { get; } = new HomeViewModel();

        public HomePage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
