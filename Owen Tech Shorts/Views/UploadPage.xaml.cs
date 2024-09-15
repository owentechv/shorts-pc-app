using System;

using Owen_Tech_Shorts.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Owen_Tech_Shorts.Views
{
    public sealed partial class UploadPage : Page
    {
        public UploadViewModel ViewModel { get; } = new UploadViewModel();

        public UploadPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
