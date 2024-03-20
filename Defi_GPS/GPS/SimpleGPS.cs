
using System.Numerics;
using System.Timers;
using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    public class SimpleGPS : BaseGPS
    {
        public SimpleGPS(float updateIntervalMS) : base(updateIntervalMS)
        {
        }

        protected override void TimerUpdate(object? sender, ElapsedEventArgs e)
        {
            GPSData data = new GPSData()
            {
                posX = 0,
                posY = 0,
            };

            OnUpdate?.Invoke(data);
        }
    }
}
