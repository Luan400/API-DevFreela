using DevFreela.Core.Service;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Instructure.MessageBus
{
    public class MessageBusService : IMessageBusService
    {
        private readonly ConnectionFactory _factory;
        public MessageBusService(IConfiguration configuration)
        {
            _factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }
        public void Publish(string queue, byte[] message)
        {
            //criar conexao
            using (var connection = _factory.CreateConnection()) { 
            
                //criar canal
            using (var channel = connection.CreateModel())
                {
                    //Garantir que a fila foi criada
                    channel.QueueDeclare(
                        queue: queue,
                        durable: false, //se a fila vai se manter dps que apagar
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    channel.BasicPublish(
                        exchange: "", //rotear msg
                        routingKey: queue,
                        basicProperties: null,
                        body: message);
                }
            }
        }
    }
}
