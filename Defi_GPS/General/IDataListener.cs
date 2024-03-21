namespace Defi_GPS.General
{
    public interface IDataListener<T>
    {
        public void Update(T data);
    }
}
