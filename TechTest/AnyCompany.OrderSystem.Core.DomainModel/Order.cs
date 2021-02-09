namespace AnyCompany.OrderSystem.Core.DomainModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public double VAT { get; set; }
    }
}
