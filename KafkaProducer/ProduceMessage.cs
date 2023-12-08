using Confluent.Kafka;

namespace KafkaProducer
{
    public class ProduceMessage
    {

        public async Task SendMessage(string BootstrapServers = "localhost:9092", string clientId = "my-app", string topic = "my-topic")
        {
            var config = new ProducerConfig
            {
                BootstrapServers = BootstrapServers,
                ClientId = clientId,
                BrokerAddressFamily = BrokerAddressFamily.V4,
            };
            using
            var producer = new ProducerBuilder<Null,
                string>(config).Build();
            Console.WriteLine("Enter the message:");
            var input = Console.ReadLine();
            
            var message = new Message<Null,string>
            {  
                Value = new CustomKafkaMessage(input!).GetMessage()
            };
            var acknowledgement = await producer.ProduceAsync(topic, message);
            Console.WriteLine($"Acknowledgement: the message has been delivered to {acknowledgement.TopicPartitionOffset}");
        }
    }

   
}
