using CommunityToolkit.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using System;

#nullable enable

namespace ModernUwpTemplate;

partial class App
{
    private IServiceProvider? _serviceProvider;

    public static IServiceProvider Services
    {
        get
        {
            IServiceProvider? serviceProvider = ((App)Current)._serviceProvider;

            if (serviceProvider is null)
            {
                ThrowHelper.ThrowInvalidOperationException("The service provider is not initialized");
            }

            return serviceProvider;
        }
    }

    private static IServiceProvider ConfigureServices()
    {
        var provider = new ServiceCollection()
            // TODO insert services here.
            // Example: .AddSingleton<IAppSettings, AppSettings>()
            .BuildServiceProvider(true);

        return provider;
    }

}
