using Ex3Events.Events;
using System.Threading;
using static Ex3Events.Program;

namespace Ex3Events.Entities
{
    public class Clock
    {
        public Clock()
        {
            Seconds = 0;
        }

        public long Seconds { get; private set; }
        public event SecondsHandler OnSecondElapsed;

        public void Start()
        {
            while (true)
            {
                Seconds++;
                if (OnSecondElapsed is not null)
                    OnSecondElapsed(this, new OnSecondElapsedEvent(Seconds));

                Thread.Sleep(1000);
            }
        }
    }
}
