using GiantBombArchiveDownloader.Library;
using Microsoft.Extensions.Configuration;

namespace GiantBombArchiveDownloader;

class Program
{
    static IConfiguration? config;

    static void Main(string[] args)
    {
        AddConfiguration();

        DownloadArchive.Download(config["jsonFilePath"], config["basePath"]);
        
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
