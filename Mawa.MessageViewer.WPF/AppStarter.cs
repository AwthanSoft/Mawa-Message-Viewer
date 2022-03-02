using Mawa.MessageViewer.Services;
using Mawa.MessageViewer.WPF.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Mawa.MessageViewer.WPF
{
    public static class AppStarter
    {
        #region Hosting
        public static void InitApp(IHostBuilder host)
        {
            host.ConfigureServices((services) =>
            {
                ConfigureServices(services);
            });
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMessageViewerService, MessageViewerService>();
        }

        #endregion
    }
}
