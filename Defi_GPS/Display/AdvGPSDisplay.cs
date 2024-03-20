using Defi_GPS.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defi_GPS.Display
{
    internal class AdvGPSDisplay : BaseGPSDisplay
    {
        public override void UpdateDisplay(GPSData data)
        {
            if (!isPoweredOn)
                return;

            Console.WriteLine("========= GPS DISPLAY 9000 =========");
            Console.WriteLine($"GPS Position [X:{data.posX}, Y:{data.posX}, Z:{data.posZ}]");
            Console.WriteLine($"GPS Rotation [X:{data.rotX}, Y:{data.rotY}, Z:{data.rotZ}]");
            Console.WriteLine("=======================================");
        }
    }
}
