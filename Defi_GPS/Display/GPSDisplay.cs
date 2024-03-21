using Defi_GPS.General;

namespace Defi_GPS.Display
{
    public class GPSDisplay : BaseGPSDisplay
    {
        public override void Update(GPSData data)
        {
            if (!isPoweredOn)
                return;

            Console.WriteLine("========= GPS DISPLAY 3000 =========");
            Console.WriteLine($"GPS Position [X:{data.posX}, Y:{data.posX}]");
            Console.WriteLine("=======================================");
        }
    }
}
