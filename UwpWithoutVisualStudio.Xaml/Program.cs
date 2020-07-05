using Microsoft.UI.Threading;
using Microsoft.UI.Xaml;

namespace UwpWithoutVisualStudio.Xaml
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Application.Start(p => { DispatcherQueueSyncContext.SetForCurrentThread(); new App(); });
        }
    }
}
