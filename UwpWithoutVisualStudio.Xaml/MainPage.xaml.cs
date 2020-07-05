using System.ComponentModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UwpWithoutVisualStudio.Xaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel { MyString = "Click me!" };
        }

        public MainViewModel ViewModel => (MainViewModel)DataContext;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.MyString = "Clicked";
        }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        private string? myString;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string? MyString
        {
            get => myString;
            set
            {
                if (myString != value)
                {
                    myString = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyString)));
                }
            }
        }
    }
}
