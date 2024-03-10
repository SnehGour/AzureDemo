using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus;
using System.Text;

const string connectionString = "Endpoint=sb://snehservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=naclyROzXr3JZMOoLCsFS7PPBs+KDXvqD+ASbPso99E=";
const string queueName = "snehqueue";
IQueueClient queueClient = new QueueClient(connectionString,queueName);
Message message = new Message(Encoding.UTF8.GetBytes("Hello"));

await queueClient.SendAsync(message);
Console.WriteLine("Send");
