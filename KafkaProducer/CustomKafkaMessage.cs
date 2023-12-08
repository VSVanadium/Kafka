namespace KafkaProducer
{
    public class CustomKafkaMessage
    {
        public string StringValue { get; set; }
        private DateTime CreatedAt { get; set; }
        public CustomKafkaMessage(string StringValue)
        {
            this.StringValue = StringValue;
            this.CreatedAt = DateTime.UtcNow;
        }

        public string GetMessage()
        {
            return $"{CreatedAt} - {StringValue}";
        }
    }
}
