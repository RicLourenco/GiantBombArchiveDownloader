using Newtonsoft.Json;

namespace GiantBombArchiveDownloader.Library.Class;

[Serializable]
public class Archive
{
    [JsonProperty("response")]
    public Response? Response { get; set; }
}