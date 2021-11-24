using Ex3Events.Entities;
using Ex3Events.Events;
using System;

namespace Ex3Events
{
    public class Program
    {
        public delegate void SecondsHandler(object sender, OnSecondElapsedEvent @event);

        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.OnSecondElapsed += OnSecondElapsed;

            clock.Start();
        }

        static void OnSecondElapsed(object sender, OnSecondElapsedEvent @event)
        {
            Console.WriteLine(@event.Seconds);
        }
    }
}
