using System;
using System.Text;
using RabbitMQ.Client;

namespace Producer
{
    class Sender
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory(){ HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("TestMessage", false, false, false, null);
                string message = "hello world =))))))";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("", "TestMessage",null,body);
                Console.WriteLine("send message {0} ...",message);
            }
            Console.WriteLine("Press [Enter] to exit ...");
            Console.ReadLine();
        }
    }
}
