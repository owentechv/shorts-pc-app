using System;

using Owen_Tech_Shorts.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Owen_Tech_Shorts.Views
{
    public sealed partial class FeedPage : Page
    {
        public FeedViewModel ViewModel { get; } = new FeedViewModel();

        public FeedPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
