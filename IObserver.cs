using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public interface IObserver
    {
        void Update(string subject, string message);
    }

    public class User : IObserver
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(string subject, string message)
        {
            Console.WriteLine($"{Name} received notification: {subject} - {message}");
        }
    }

    public class NotificationPublisher
    {
        private List<IObserver> _subscribers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

        public void NotifyAll(string subject, string message)
        {
            foreach (var observer in _subscribers)
            {
                observer.Update(subject, message);
            }
        }
    }

}
