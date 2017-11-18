namespace dm
{
    public class KeyValueViewModel<T>
    {
        public string Key { get; set; }

        public T Value { get; set; }

        public KeyValueViewModel()
        {

        }

        public KeyValueViewModel(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}