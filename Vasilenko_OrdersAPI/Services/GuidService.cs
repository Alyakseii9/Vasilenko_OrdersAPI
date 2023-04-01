namespace Vasilenko_OrdersAPI.Services
{
    public sealed class GuidService :IGuidServices
    {
        private Guid _value;
        public GuidService()
        {
            _value = Guid.NewGuid();
        }
        public Guid Value
        {
            get { return _value; }
        }
    }
}
