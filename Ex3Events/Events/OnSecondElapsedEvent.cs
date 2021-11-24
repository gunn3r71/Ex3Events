using System;

namespace Ex3Events.Events
{
    public class OnSecondElapsedEvent : EventArgs
    {
        public OnSecondElapsedEvent(long seconds)
        {
            Seconds = seconds;
        }

        public long Seconds { get; private set; }
    }
}
