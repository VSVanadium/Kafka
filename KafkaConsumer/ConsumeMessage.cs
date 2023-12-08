using Confluent.Kafka;

namespace KafkaConsumer
{
    public class ConsumeMessage
    {
        private readonly ConsumerConfig? _config;

        public ConsumeMessage(string bootstrapServer = "localhost:9092", string clientID = "my-app", string groupID = "my-group") 
        {
            _config = new ConsumerConfig
            {
                BootstrapServers = bootstrapServer,
                AutoOffsetReset = AutoOffsetReset.Earliest,
                ClientId = clientID,
                GroupId = groupID,
                BrokerAddressFamily = BrokerAddressFamily.V4,
            };
        }
        public void ReadMessage(string topic = "my-topic")
        {

            using (var consumer = new ConsumerBuilder<Ignore, string>(_config).Build())
            {
                consumer.Subscribe(topic);
                try
                {
                    while (true)
                    {
                        var consumeResult = consumer.Consume();
                        Console.WriteLine($"Message received from {consumeResult.TopicPartitionOffset}: {consumeResult.Message.Value}");
                    }
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    consumer.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
