using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(StreamWebPage.Areas.Identity.IdentityHostingStartup))]

namespace StreamWebPage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}