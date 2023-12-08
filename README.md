# Kafka

Prerequisites
Java: Kafka is written in Java, so you need to have Java installed on your Windows system
Zookeeper: Kafka relies on Zookeeper for distributed coordination. You can download Zookeeper

Visit the Kafka downloads page: Kafka Downloads. Download the latest stable version of Kafka for Windows.
Extract the downloaded Kafka archive to a directory of your choice, e.g., C:\kafka.

Inside the Kafka directory, there is a file called config/zookeeper.properties. Open this file and modify the dataDir property to a directory where Zookeeper can store its data.
For example: dataDir=C:/kafka/data/zookeeper

## Start Zookeeper
Open a command prompt and navigate to the Kafka directory. Start Zookeeper by running the following command:
bin\windows\zookeeper-server-start.bat config\zookeeper.properties

## Start Kafka Broker
new command prompt, navigate to the Kafka directory, and start the Kafka broker by running the following command:
bin\windows\kafka-server-start.bat config\server.properties
Start Kafka Server:
   - Open a terminal or command prompt.
   - Navigate to the Kafka installation directory.
   - Start the ZooKeeper server (if not already running) by running the following command: `bin/zookeeper-server-start.sh config/zookeeper.properties`
   - Start the Kafka server by running the following command: `bin/kafka-server-start.sh config/server.properties`
   
## Stop Kafka Server:
   - Open a new terminal or command prompt.
   - Navigate to the Kafka installation directory.
   - Stop the Kafka server by running the following command: `bin/kafka-server-stop.sh`


