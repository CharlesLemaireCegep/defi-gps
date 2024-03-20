using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    public interface IGPS
    {
        public void PowerOn();
        public void PowerOff();

        public void Connect(Action<GPSData> action);
        public void Disconnect(Action<GPSData> action);
    }
}
