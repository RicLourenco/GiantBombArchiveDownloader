using GiantBombArchiveDownloader.Library;
using Microsoft.Extensions.Configuration;

namespace GiantBombArchiveDownloader;

class Program
{
    static IConfiguration? config;

    static void Main(string[] args)
    {
        AddConfiguration();

        if(config is null)
        {
            Console.WriteLine("There is no configuration!");
            return;
        }

        var jsonFilePath = config["jsonFilePath"];
        var basePath = config["basePath"];

        if(jsonFilePath is null
            || basePath is null)
        {
            Console.WriteLine("Configuration is missing parameters!");
            return;
        }
        
        DownloadArchive.Download(jsonFilePath, basePath);

        //RenameDirectory.RenameDirectories();
    }

    static void AddConfiguration()
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        
        config = builder.Build();
    }
}
