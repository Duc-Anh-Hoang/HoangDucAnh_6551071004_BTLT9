using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Bai_2;

public class AppConfig
{
    public ConnectionStringsConfig ConnectionStrings { get; set; } = new();
}

public class ConnectionStringsConfig
{
    public string DefaultConnection { get; set; } = string.Empty;
}

public static class AppConfigManager
{
    public static AppConfig Config { get; private set; } = new();

    static AppConfigManager()
    {
        LoadConfiguration();
    }

    public static void LoadConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

        var configuration = builder.Build();
        var appConfig = new AppConfig();
        configuration.Bind(appConfig);
        Config = appConfig;
    }

    public static string ConnectionString => Config.ConnectionStrings.DefaultConnection;
}
