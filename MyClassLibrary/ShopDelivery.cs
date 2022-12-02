namespace MyClassLibrary
{
    public class ShopDelivery : Delivery
    {
        public ShopDelivery(string address) : base(address)
        {         
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка в розничный магазин по адресу: {0}", Address);
        }
    }
}
