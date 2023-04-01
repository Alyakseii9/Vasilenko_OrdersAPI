namespace Vasilenko_OrdersAPI.Services
{
    public sealed class UidService
    {

        public decimal Total { get; set; }

        public int BuyerId { get; set; }

        protected internal IGuidServices GUID { get; }
        public UidService(IGuidServices _GUID)
        {
            GUID = _GUID;
        }
    }
}
