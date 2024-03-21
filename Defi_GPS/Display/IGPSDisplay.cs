using Defi_GPS.General;

namespace Defi_GPS.Display
{
    public interface IGPSDisplay : IDataListener<GPSData>, IPowerable
    {
        // GPS Display only things here
    }
}
