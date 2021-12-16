using Newtonsoft.Json;

namespace Barney.Microservice.Models
{
    public class VersionDto
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}