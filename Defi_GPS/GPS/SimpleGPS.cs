
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
            var data = new DataDict
            {
                { GPSDataKeys.POS_X, 0 },
                { GPSDataKeys.POS_Y, 0 }
            };

            OnUpdate?.Invoke(data);
        }
    }
}
