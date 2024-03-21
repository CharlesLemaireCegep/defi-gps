using System.Timers;
using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    public abstract class BaseGPS : IGPS
    {
        protected System.Timers.Timer timer = new System.Timers.Timer();
        protected Action<GPSData>? OnUpdate;

        public BaseGPS(float updateIntervalMS)
        {
            timer.Interval = updateIntervalMS;
            timer.Elapsed += TimerUpdate;
        }

        public void Connect(IDataListener<GPSData> action)
        {
            OnUpdate += action.Update;
        }

        public void Disconnect(IDataListener<GPSData> action)
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
            OnUpdate = null;
        }

        protected abstract void TimerUpdate(object? sender, ElapsedEventArgs e);
    }
}
