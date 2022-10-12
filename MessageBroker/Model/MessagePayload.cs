using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBroker.Model
{
    public class MessagePayload<T>
    {
        public object Who { get; private set; }
        public T What { get; private set; }
        public DateTime When { get; private set; }
        public MessagePayload(T payload, object source)
        {
            Who = source; What = payload; When = DateTime.UtcNow;
        }
    }
}
