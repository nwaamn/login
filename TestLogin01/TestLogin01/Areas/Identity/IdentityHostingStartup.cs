using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestLogin01.Areas.Identity.Data;
using TestLogin01.Models;

[assembly: HostingStartup(typeof(TestLogin01.Areas.Identity.IdentityHostingStartup))]
namespace TestLogin01.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TestContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FARMContextConnection")));

                services.AddDefaultIdentity<Ctm>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TestContext>();
            });
        }
    }
}