using Defi_GPS.Controller;
using Defi_GPS.Display;
using Defi_GPS.GPS;

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

while (true)
{
    await Task.Delay(1);
}