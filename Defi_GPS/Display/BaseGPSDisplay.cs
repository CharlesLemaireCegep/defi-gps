using Defi_GPS.General;

namespace Defi_GPS.Display
{
    public abstract class BaseGPSDisplay : IGPSDisplay
    {
        protected bool isPoweredOn = false;

        public virtual void PowerOn()
        {
            isPoweredOn = true;
        }

        public virtual void PowerOff()
        {
            isPoweredOn = false;
        }

        public abstract void Update(GPSData data);
    }
}
