using PayloadBuilder.Models;

namespace PayloadBuilder.Builders
{
    public class PayloadCreator
    {
        private readonly Payload _result;

        public PayloadCreator()
        {
            _result = new Payload();
        }

        public PayloadCreator WithName(string name)
        {
            _result.Name = name;
            return this;
        }

        public PayloadCreator WithField(string key, object value)
        {
            _result.Fields[key] = value;
            return this;
        }

        public PayloadCreator WithoutField(string key)
        {
            if (_result.Fields.ContainsKey(key))
                _result.Fields.Remove(key);

            return this;
        }

        public Payload Build()
        {
            return _result;
        }
    }
}
