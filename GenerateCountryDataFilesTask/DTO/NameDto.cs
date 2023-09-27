using Newtonsoft.Json;

namespace GenerateCountryDataFilesTask.DTO
{
    public class NameDto
    {
        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
