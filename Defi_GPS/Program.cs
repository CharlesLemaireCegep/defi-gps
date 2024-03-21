using Defi_GPS.Controller;
using Defi_GPS.Display;
using Defi_GPS.GPS;
using Defi_GPS.ModuleX;

// GPS
SimpleGPS simpleGPS = new SimpleGPS(1000);
AdvancedGPS advancedGPS = new AdvancedGPS(1000);

// Displays
GPSDisplay gpsDisplay = new GPSDisplay();
AdvGPSDisplay advGPSDisplay = new AdvGPSDisplay();

GPSController GPS_ctrl = new GPSController();


Console.WriteLine("======================================");
Console.WriteLine("Connecting 2 displays + Simple GPS");
Console.WriteLine("======================================\n");
GPS_ctrl.ConnectGPS(simpleGPS);
GPS_ctrl.ConnectGPSDisplay(gpsDisplay);
GPS_ctrl.ConnectGPSDisplay(advGPSDisplay);
GPS_ctrl.PowerOn();

await Task.Delay(5000);
Console.WriteLine("\n======================================");
Console.WriteLine("Connecting Module X");
Console.WriteLine("======================================\n");
ModuleX x = new ModuleX();
GPS_ctrl.Connect(x);

await Task.Delay(5000);
GPS_ctrl.DisconnectGPS(simpleGPS);
GPS_ctrl.ConnectGPS(advancedGPS);
Console.WriteLine("\n======================================");
Console.WriteLine("Switching GPS Simple -> AdvancedGPS");
Console.WriteLine("======================================\n");
GPS_ctrl.Reboot();

await Task.Delay(5000);
GPS_ctrl.DisconnectGPSDisplay(gpsDisplay);
GPS_ctrl.DisconnectGPSDisplay(advGPSDisplay);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting all Displays");
Console.WriteLine("======================================\n");

await Task.Delay(5000);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting Module X");
Console.WriteLine("======================================\n");
GPS_ctrl.Disconnect(x);

await Task.Delay(2000);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting GPS Module and shutdown Controller");
Console.WriteLine("======================================\n");
GPS_ctrl.DisconnectGPS(simpleGPS);

await Task.Delay(2000);
Console.WriteLine("ALL SYSTEMS OFF!");
GPS_ctrl.PowerOff();

while (true)
{
    await Task.Delay(1);
}