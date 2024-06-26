﻿using Defi_GPS.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defi_GPS.Display
{
    internal class AdvGPSDisplay : BaseGPSDisplay
    {
        public override void Update(GPSData data)
        {
            if (!isPoweredOn)
                return;
            Console.WriteLine($"Advanced Display:   [X:{data.posX}, Y:{data.posY}, Z:{data.posZ}] [X:{data.rotX}, Y:{data.rotY}, Z:{data.rotZ}]");
        }
    }
}
