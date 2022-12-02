namespace MyClassLibrary
{
	public class Order<TDelivery>
		where TDelivery : Delivery
	{
		public Customer Customer { get; private set; }
		public ProductCollection Products { get; private set; }
		public Order(Customer customer, Delivery delivery, ProductCollection products, int number, string description)
		{
			Customer = customer;	
			Products = products;
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
