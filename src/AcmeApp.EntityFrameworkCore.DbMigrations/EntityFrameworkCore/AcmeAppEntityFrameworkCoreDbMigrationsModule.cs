﻿using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace AcmeApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(AcmeAppEntityFrameworkCoreModule)
        )]
    public class AcmeAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AcmeAppMigrationsDbContext>();
        }
    }
}
