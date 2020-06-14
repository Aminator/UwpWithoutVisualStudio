using System;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;

namespace UwpWithoutVisualStudio
{
    public class App : IFrameworkViewSource, IFrameworkView
    {
        public IFrameworkView CreateView() => this;

        public void Initialize(CoreApplicationView applicationView)
        {
            applicationView.Activated += OnApplicationViewActivated;
        }

        public void SetWindow(CoreWindow window)
        {
            ExtendViewIntoTitleBar(true);
        }

        public void Load(string entryPoint)
        {
        }

        public void Run()
        {
            CoreWindow.GetForCurrentThread().Dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessUntilQuit);
        }

        public void Uninitialize()
        {
        }

        private async void OnApplicationViewActivated(CoreApplicationView sender, IActivatedEventArgs e)
        {
            sender.CoreWindow.Activate();

            MessageDialog dialog = new MessageDialog("Hello from .NET 5!");
            await dialog.ShowAsync();
        }

        private static void ExtendViewIntoTitleBar(bool extendViewIntoTitleBar)
        {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = extendViewIntoTitleBar;

            if (extendViewIntoTitleBar)
            {
                ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
                titleBar.ButtonBackgroundColor = Color.FromArgb(0, 0, 0, 0);
                titleBar.ButtonInactiveBackgroundColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
    }
}
