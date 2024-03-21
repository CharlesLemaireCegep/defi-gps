using Defi_GPS.Controller;
using Defi_GPS.Display;
using Defi_GPS.GPS;
using Defi_GPS.ModuleX;
using System.Reflection;

// GPS
SimpleGPS simpleGPS = new SimpleGPS(1000);
AdvancedGPS advancedGPS = new AdvancedGPS(10);

// Displays
GPSDisplay gpsDisplay = new GPSDisplay();
AdvGPSDisplay advGPSDisplay = new AdvGPSDisplay();

GPSController GPS_ctrl = new GPSController();

GPS_ctrl.ConnectGPS(simpleGPS);
GPS_ctrl.ConnectGPSDisplay(gpsDisplay);
GPS_ctrl.ConnectGPSDisplay(advGPSDisplay);
GPS_ctrl.PowerOn();

Console.WriteLine("Waiting 5 seconds to connect Module X");
await Task.Delay(5000);
ModuleX x = new ModuleX();
GPS_ctrl.ConnectListener(x);

while (true)
{
    await Task.Delay(1);
}