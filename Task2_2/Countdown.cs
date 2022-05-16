using System;
using System.Collections.Generic;
using System.Threading;

    public class Countdown {
        List<Customer> observers = new List<Customer>();

        public void subscribe(Customer observer)
        {
            observers.Add(observer);
        }
        public void unsubscribe(Customer observer)
        {
            observers.Remove(observer);
        }
        public void notify(int delay, string message) {
            Thread.Sleep(delay);
            Console.WriteLine(message);
            foreach (var observer in observers)
            {
                observer.display(message);
            }
                Console.WriteLine();
        }
    }