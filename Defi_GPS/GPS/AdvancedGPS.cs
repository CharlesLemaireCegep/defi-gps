using System.Timers;
using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    internal class AdvancedGPS : BaseGPS
    {
        public AdvancedGPS(float updateIntervalMS) : base(updateIntervalMS)
        {
        }

        protected override void TimerUpdate(object? sender, ElapsedEventArgs e)
        {
            var data = new DataDict
            {
                { GPSDataKeys.POS_X, 1 },
                { GPSDataKeys.POS_Y, 2 },
                { GPSDataKeys.POS_Z, 3 },
                { GPSDataKeys.ROT_X, 11.11f },
                { GPSDataKeys.ROT_Y, 22.22f },
                { GPSDataKeys.ROT_Z, 33.33f },
            };

            OnUpdate?.Invoke(data);
        }
    }
}
