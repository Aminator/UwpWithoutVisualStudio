using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpWithoutVisualStudio.Xaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool isContentLoaded;

        public MainPage()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            if (isContentLoaded) return;

            isContentLoaded = true;

            Uri resourceLocator = new Uri("ms-appx:///MainPage.xaml");
            Application.LoadComponent(this, resourceLocator, ComponentResourceLocation.Application);
        }
    }
}
