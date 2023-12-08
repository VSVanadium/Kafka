using Newtonsoft.Json;

namespace KafkaProducer
{
    public class KafkaConfig
    {
        [JsonProperty("BootstrapServers")]
        public string? BootstrapServers { get; set; }

        [JsonProperty("ClientId")]
        public string? ClientId { get; set; }

        [JsonProperty("GroupId")]
        public string? GroupId { get; set; }

        [JsonProperty("Topic")]
        public string? Topic { get; set; }
    }
}
