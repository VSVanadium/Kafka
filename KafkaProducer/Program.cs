using KafkaProducer;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

KafkaConfig kafkaConfig = configuration.GetSection("KafkaConfig").Get<KafkaConfig>();


Console.WriteLine("Hello, World");
Console.WriteLine("Welcome to message sending application");

ProduceMessage produceMessage = new ProduceMessage();

var task = Task.Run(() =>
{           
    while (true)
    {
        produceMessage.SendMessage(kafkaConfig!.BootstrapServers!, kafkaConfig.ClientId!, kafkaConfig.Topic!).Wait();
    }
});

await task;
        


