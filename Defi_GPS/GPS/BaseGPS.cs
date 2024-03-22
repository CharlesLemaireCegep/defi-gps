using System.Timers;
using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    public abstract class BaseGPS : IGPS
    {
        protected System.Timers.Timer timer = new System.Timers.Timer();
        protected Action<DataDict>? OnUpdate;

        public BaseGPS(float updateIntervalMS)
        {
            timer.Interval = updateIntervalMS;
            timer.Elapsed += TimerUpdate;
        }

        public void Connect(IDataListener action)
        {
            OnUpdate += action.Update;
        }

        public void Disconnect(IDataListener action)
        {
            OnUpdate -= action.Update;
        }

        public void PowerOn()
        {
            if (timer.Enabled)
                return;

            timer.Start();
        }

        public void PowerOff()
        {
            timer.Stop();
        }

        protected abstract void TimerUpdate(object? sender, ElapsedEventArgs e);
    }
}
