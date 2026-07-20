using PayloadBuilder.Models;

namespace PayloadBuilder.Builders
{
    public class PayloadBuilder
    {
        private readonly Payload _payload = new();

        public PayloadBuilder SetName(string name)
        {
            _payload.Name = name;
            return this;
        }

        public PayloadBuilder AddField(string key, object value)
        {
            _payload.Fields[key] = value;
            return this;
        }

        public PayloadBuilder RemoveField(string key)
        {
            if (_payload.Fields.ContainsKey(key))
                _payload.Fields.Remove(key);

            return this;
        }

        public Payload Build()
        {
            return _payload;
        }
    }
}
