using Defi_GPS.General;

namespace Defi_GPS.GPS
{
    public interface IGPS : IPowerable, IConnectable<GPSData>
    {
        // GPS only things here
    }
}
