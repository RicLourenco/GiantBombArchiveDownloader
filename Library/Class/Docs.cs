using Newtonsoft.Json;

namespace GiantBombArchiveDownloader.Library.Class;

[JsonObject("docs")]
public class Docs
{
    [JsonProperty("identifier")]
    public string? Id { get; set; }
    
    [JsonProperty("title")]
    public string? Title { get; set; }
}