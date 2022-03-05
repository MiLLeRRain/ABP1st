using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ABP1st;

public class ABP1stWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ABP1stWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
