﻿namespace Defi_GPS.General
{

    /// <summary>
    /// Allows any external modules to connect/disconnect with an action of the T structure
    /// </summary>
    /// <typeparam name="T">Structure of the receiving data</typeparam>
    public interface IConnectable<T> where T : struct
    {
        public void Connect(IDataListener<T> listener);
        public void Disconnect(IDataListener<T> listener);
    }
}
