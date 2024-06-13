namespace DrawMaster.Rectangle;
public static class ConfigUtils
{
    private static readonly IConfiguration Configuration = new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();

    public static string GetJsonUrl()
    {
        return $"{Configuration["JsonUrl"]}";
    }
    
}