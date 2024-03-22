using Defi_GPS.General;
using System.Text;

namespace Defi_GPS.Display
{
    public class GPSDisplay : BaseGPSDisplay
    {
        public override void Update(DataDict data)
        {
            if (!isPoweredOn)
                return;

            StringBuilder dataString = new StringBuilder();
            dataString.Append("Simple Display: [");

            if (data.TryGetVal(GPSDataKeys.POS_X, out int posX))
            {
                dataString.Append($"PX: {posX}, ");
            }

            if (data.TryGetVal(GPSDataKeys.POS_Y, out int posY))
            {
                dataString.Append($"PY: {posY}");
            }

            dataString.Append("]");
            Console.WriteLine(dataString.ToString());
        }
    }
}
