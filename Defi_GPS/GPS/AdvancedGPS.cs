
using System.Numerics;
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
            GPSData data = new GPSData()
            {
                posX = 1,
                posY = 2,
                posZ = 3,
                rotX = 4,
                rotY = 5,
                rotZ = 6
            };

            OnUpdate?.Invoke(data);
        }
    }
}
