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

// Module X 
ModuleX x = new ModuleX();

// Connection all of the displays and starting up the main controller
GPS_ctrl.ConnectGPS(simpleGPS);
GPS_ctrl.ConnectGPSDisplay(gpsDisplay);
GPS_ctrl.ConnectGPSDisplay(advGPSDisplay);
GPS_ctrl.PowerOn();
Console.WriteLine("======================================");
Console.WriteLine("Connecting 2 displays + Simple GPS");
Console.WriteLine("======================================\n");

// Connection the Module X
await Task.Delay(5000);
GPS_ctrl.Connect(x);
Console.WriteLine("\n======================================");
Console.WriteLine("Connecting Module X");
Console.WriteLine("======================================\n");

// Switching GPS Simple -> AdvancedGPS
await Task.Delay(5000);
GPS_ctrl.DisconnectGPS(simpleGPS);
GPS_ctrl.ConnectGPS(advancedGPS);
Console.WriteLine("\n======================================");
Console.WriteLine("Switching GPS Simple -> AdvancedGPS");
Console.WriteLine("======================================\n");
GPS_ctrl.Reboot();

// Disconnecting all Displays
await Task.Delay(5000);
GPS_ctrl.DisconnectGPSDisplay(gpsDisplay);
GPS_ctrl.DisconnectGPSDisplay(advGPSDisplay);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting all Displays");
Console.WriteLine("======================================\n");

// Disconnecting Module X
await Task.Delay(5000);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting Module X");
Console.WriteLine("======================================\n");
GPS_ctrl.Disconnect(x);

// Disconnecting GPS Module and shutdown Controller
await Task.Delay(2000);
GPS_ctrl.DisconnectGPS(simpleGPS);
Console.WriteLine("\n======================================");
Console.WriteLine("Disconnecting GPS Module and shutdown Controller");
Console.WriteLine("======================================\n");

// Shuthing down the main controller
await Task.Delay(2000);
GPS_ctrl.PowerOff();
Console.WriteLine("ALL SYSTEMS OFF!");

while (true)
{
    await Task.Delay(1);
}