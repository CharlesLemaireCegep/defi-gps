using Defi_GPS.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defi_GPS.Display
{
    public abstract class BaseGPSDisplay : IGPSDisplay, IModule
    {
        protected bool isPoweredOn = false;

        public virtual void PowerOn()
        {
            isPoweredOn = true;
        }

        public virtual void PowerOff()
        {
            isPoweredOn = false;
        }

        public abstract void UpdateDisplay(GPSData data);
    }
}
