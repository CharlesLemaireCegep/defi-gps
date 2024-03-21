using Defi_GPS.Display;
using Defi_GPS.General;
using Defi_GPS.GPS;

namespace Defi_GPS.Controller
{
    internal class GPSController : IPowerable, IDataListener<GPSData>, IConnectable<GPSData>
    {
        protected bool isPoweredOn = false;

        Action<GPSData>? OnUpdate;
        Action? OnPowerOn;
        Action? OnPowerOff;

        // GPS System
        public void ConnectGPS(IGPS gps)
        {
            gps.Connect(this);
            OnPowerOn += gps.PowerOn;
            OnPowerOff += gps.PowerOff;
        }

        public void DisconnectGPS(IGPS gps)
        {
            gps.Disconnect(this);
            OnPowerOn -= gps.PowerOn;
            OnPowerOff -= gps.PowerOff;
        }

        // GPS Display
        public void ConnectGPSDisplay(IGPSDisplay display)
        {
            OnUpdate += display.Update;
            OnPowerOn += display.PowerOn;
            OnPowerOff += display.PowerOff;
        }

        public void DisconnectGPSDisplay(IGPSDisplay display)
        {
            OnUpdate -= display.Update;
            OnPowerOn -= display.PowerOn;
            OnPowerOff -= display.PowerOff;
        }

        public void Connect(IDataListener<GPSData> listener)
        {
            OnUpdate += listener.Update;
        }

        public void Disconnect(IDataListener<GPSData> listener)
        {
            OnUpdate -= listener.Update;
        }

        public void PowerOn()
        {
            isPoweredOn = true;
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            isPoweredOn = false;
            OnPowerOff?.Invoke();
        }

        public void Reboot()
        {
            PowerOff();
            PowerOn();
        }

        public void Update(GPSData data)
        {
            if (!isPoweredOn)
                return;

            OnUpdate?.Invoke(data);
        }
    }
}
