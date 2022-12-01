namespace MyClassLibrary
{
	public class Order<TDelivery, TClass>
		where TDelivery : Delivery
		where TClass : class
	{
		public ProductCollection products;
		public Order(Delivery delivery, ProductCollection products, int number, string description)
		{
			this.products = products;
			this.delivery = (TDelivery)delivery;
			Number = number;
			Description = description;
		}

		public TDelivery delivery;

		public int Number { get; private set; }

		public string Description { get; private set; }

		public void DisplayAddress()
		{
			Console.WriteLine(delivery.Address);
		}
	}
}
