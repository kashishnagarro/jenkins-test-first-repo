using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFirst.Queue
{
    public class Publisher<T>
    {
        public static void Publish(T data)
        {
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "guest", Password = "guest" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "demo.queue.sample",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = "Latitude: 484848, Longitude: 1233444 and Time: " + DateTime.Now;
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "demo.exchange",
                                     routingKey: "demo.queue.routingKey",
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
