using Defi_GPS.General;
namespace Defi_GPS.ModuleX
{
    internal class ModuleX : IDataListener<GPSData>, IDataListener<string>
    {
        public void Update(GPSData data)
        {
            Console.WriteLine($"Module X got the GPS DATA!");
        }

        public void Update(string data)
        {
            Console.WriteLine($"Module X got some string data: {data}");
        }
    }
}
