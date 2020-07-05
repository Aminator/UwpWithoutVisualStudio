using Microsoft.UI.Threading;
using Microsoft.UI.Xaml;
using WinRT;

namespace UwpWithoutVisualStudio.Xaml
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ComWrappersSupport.InitializeComWrappers();
            Application.Start(p => { DispatcherQueueSyncContext.SetForCurrentThread(); new App(); });
        }
    }
}
