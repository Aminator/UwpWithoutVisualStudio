using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpWithoutVisualStudio.Xaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Grid grid = new Grid();

            grid.Children.Add(new Button
            {
                Content = "Hello World",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            });

            Content = grid;
        }
    }
}
