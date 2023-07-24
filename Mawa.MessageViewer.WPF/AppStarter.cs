using Mawa.DependencyInjection.Controls;
using Mawa.MessageViewer.Services;
using Mawa.MessageViewer.WPF.Services;

namespace Mawa.MessageViewer.WPF
{
    public static class AppStarter
    {
        #region Hosting
        //public static void InitApp(IHostBuilder host)
        //{
        //    host.ConfigureServices((services) =>
        //    {
        //        ConfigureServices(services);
        //    });
        //}

        public static void ConfigureServices(ICollectionServicesControl CollectionServicesCtrl)
        {
            CollectionServicesCtrl.AddSingleton<IMessageViewerService, MessageViewerService>();
        }

        #endregion
    }
}
