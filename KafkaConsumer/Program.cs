using KafkaConsumer;
using KafkaProducer;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

KafkaConfig kafkaConfig = configuration.GetSection("KafkaConfig").Get<KafkaConfig>();

Console.WriteLine("Hello, World!");
Console.WriteLine("Messages will be displayed, as soon as we receive them:");
ConsumeMessage produceMessage = new ConsumeMessage(kafkaConfig!.BootstrapServers!, kafkaConfig.ClientId!, kafkaConfig.GroupId!);
produceMessage.ReadMessage(kafkaConfig.Topic!);
