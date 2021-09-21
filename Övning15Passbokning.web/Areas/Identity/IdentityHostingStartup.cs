using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Övning15Passbokning.Core.Models.Entities;
using Övning15Passbokning.Data.Data;

[assembly: HostingStartup(typeof(Övning15Passbokning.Web.Areas.Identity.IdentityHostingStartup))]
namespace Övning15Passbokning.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}