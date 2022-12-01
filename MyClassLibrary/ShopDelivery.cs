namespace MyClassLibrary
{
	public class ShopDelivery : Delivery
	{
		private Company company;
		public ShopDelivery(string address) : base(address)
		{
		}
		public override void Deliver()
		{
			company.Deliver(Address);
		}
	}
}
