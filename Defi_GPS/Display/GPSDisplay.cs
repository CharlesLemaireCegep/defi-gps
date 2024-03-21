using Defi_GPS.General;

namespace Defi_GPS.Display
{
    public class GPSDisplay : BaseGPSDisplay
    {
        public override void Update(GPSData data)
        {
            if (!isPoweredOn)
                return;

            Console.WriteLine($"Simple Display:     [X:{data.posX}, Y:{data.posY}]");
        }
    }
}
