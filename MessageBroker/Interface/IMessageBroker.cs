using MessageBroker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBroker.Interface
{
    public interface IMessageBroker : IDisposable
    {
        void Publish<T>(object source, T message);
        void Subscribe<T>(Action<MessagePayload<T>> subscription);
        void Unsubscribe<T>(Action<MessagePayload<T>> subscription);
    }
}
