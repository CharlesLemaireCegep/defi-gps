using Defi_GPS.General;
namespace Defi_GPS.ModuleX
{
    internal class ModuleX : IDataListener
    {
        public void Update(DataDict data)
        {
            Console.WriteLine($"Module X got the GPS DATA!");
        }
    }
}
