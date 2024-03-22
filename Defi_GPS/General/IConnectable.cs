namespace Defi_GPS.General
{

    /// <summary>
    /// Allows any external modules to connect/disconnect with an action of the T structure
    /// </summary>
    /// <typeparam name="T">Structure of the receiving data</typeparam>
    public interface IConnectable
    {
        public void Connect(IDataListener listener);
        public void Disconnect(IDataListener listener);
    }
}
