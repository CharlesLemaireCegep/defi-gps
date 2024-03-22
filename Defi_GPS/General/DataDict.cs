namespace Defi_GPS.General
{
    public class DataDict : Dictionary<string, object>
    {
        public bool TryGetVal<T>(string key, out T? value)
        {
            bool res = TryGetValue(key, out object? objVal);
            if (objVal is T TValue)
            {
                value = TValue;
            }
            else
            {
                value = default; // null or default value
            }

            return res;
        }
    }
}
