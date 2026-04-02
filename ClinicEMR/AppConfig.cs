using Microsoft.Extensions.Configuration;

public static class AppConfig
{
    public static IConfigurationRoot? Configuration { get; private set; }

    public static void Init()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }
}
