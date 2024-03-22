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
        public override void Update(DataDict data)
        {
            if (!isPoweredOn)
                return;

            StringBuilder dataString = new StringBuilder();
            dataString.Append("Advanced Display: [");

            // Positions
            if (data.TryGetVal(GPSDataKeys.POS_X, out int posX))
            {
                dataString.Append($"PX: {posX}, ");
            }

            if (data.TryGetVal(GPSDataKeys.POS_Y, out int posY))
            {
                dataString.Append($"PY: {posY}, ");
            }

            if (data.TryGetVal(GPSDataKeys.POS_Z, out int posZ))
            {
                dataString.Append($"PZ: {posZ}");
            }

            // rotations
            if (data.TryGetVal(GPSDataKeys.ROT_X, out float rotX))
            {
                dataString.Append($"RX: {rotX}, ");
            }

            if (data.TryGetVal(GPSDataKeys.ROT_Y, out float rotY))
            {
                dataString.Append($"RY: {rotY}, ");
            }

            if (data.TryGetVal(GPSDataKeys.ROT_Z, out float rotZ))
            {
                dataString.Append($"RZ: {rotZ}");
            }

            dataString.Append("]");
            Console.WriteLine(dataString.ToString());
        }
    }
}
