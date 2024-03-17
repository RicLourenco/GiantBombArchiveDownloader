using GiantBombArchiveDownloader.Library.Class;
using Newtonsoft.Json;

namespace GiantBombArchiveDownloader.Library;

public static class DownloadArchive
{
    public static void Download(string jsonSourcePath, string basePath)
    {
        Archive? Archive = JsonConvert.DeserializeObject<Archive>(File.ReadAllText(jsonSourcePath));
        string directory;

        if(string.IsNullOrEmpty(Archive.Response.Series))
        {
            throw new Exception("JSON file does not contain series name in the response!");
        }
        else
        {
            directory = basePath + Archive.Response.Series;
        }
        
        Directory.CreateDirectory(directory);

        var builder = new UriBuilder(@$"https://archive.org/");
        var client = new HttpClient();

        try
        {
            for(byte i = 0; i < Archive.Response.NumberFound ;i++)
            {
                builder.Path = $"download/{Archive.Response.Docs[i].Id:00}/{Archive.Response.Docs[i].Id:00}_archive.torrent";
                Console.WriteLine($"Getting from {builder.Uri}...");
                var contentBytes = client.GetByteArrayAsync(builder.Uri).Result;
                var stream = new MemoryStream(contentBytes);
                var file = new FileStream(@$"{directory}/{Archive.Response.Docs[i].Title}_archive.torrent", FileMode.Create, FileAccess.Write);
                stream.WriteTo(file);
                file.Close();
                stream.Close();

                if(i < Archive.Response.NumberFound - 1)
                {
                    Console.WriteLine("Goteem!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
        }
        catch (Exception e)
        {
            //Directory.Delete(directory);
            Console.WriteLine($"Error!\n{e.Message}");
        }
    }
}