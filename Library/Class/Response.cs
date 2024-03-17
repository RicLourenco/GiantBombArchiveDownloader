using Newtonsoft.Json;

namespace GiantBombArchiveDownloader.Library.Class;

[JsonObject("response")]
public class Response
{
    [JsonProperty("numFound")]
    public short NumberFound { get; set; }

    [JsonProperty("start")]
    public byte Start { get; set; }

    [JsonProperty("docs")]
    public List<Docs>? Docs { get; set; }

    [JsonProperty("series")]
    public string? Series { get; set; }
}