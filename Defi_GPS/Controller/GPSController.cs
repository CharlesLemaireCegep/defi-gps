using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defi_GPS.Display;
using Defi_GPS.General;
using Defi_GPS.GPS;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Defi_GPS.Controller
{
    internal class GPSController
    {
        IGPS? gpsModule;
        List<BaseGPSDisplay> gpsDisplays = new List<BaseGPSDisplay>(); // list of displays to update

        // GPS System
        public void ConnectGPS(IGPS gps)
        {
            // if there is a current GPS, disconnect it before connecting the other one
            if (gpsModule != null)
                DisconnectGPS(gpsModule);

            gpsModule = gps;
            gpsModule.Connect(Update);
        }

        public void DisconnectGPS(IGPS gps)
        {
            if (gpsModule == null)
                return;

            gpsModule.Disconnect(Update);
            gpsModule = null;
        }

        // GPS Display
        public void ConnectGPSDisplay(BaseGPSDisplay display)
        {
            if (!gpsDisplays.Contains(display))
                gpsDisplays.Add(display);
        }

        public void DisconnectGPSDisplay(BaseGPSDisplay display)
        {
            if (gpsDisplays.Contains(display))
                gpsDisplays.Remove(display);
        }

        public void PowerOn()
        {
            gpsModule?.PowerOn();
            foreach (var display in gpsDisplays)
            {
                display.PowerOn();
            }
        }

        public void PowerOff()
        {
            gpsModule?.PowerOff();
            foreach (var display in gpsDisplays)
            {
                display.PowerOff();
            }
        }

        public void Update(GPSData data)
        {
            foreach (var display in gpsDisplays)
            {
                display.UpdateDisplay(data);
            }
        }
    }
}
