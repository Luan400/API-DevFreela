using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Service
{
    public interface IMessageBusService
    {
        //queue é a fila, depois converte em byte a mensagem
        void Publish(string queue, byte[] message);
    }
}
