namespace MyClassLibrary
{
	public class Order<TDelivery, TNumber>
		where TDelivery : Delivery
	{
		public Customer Customer { get; private set; }
		public ProductCollection Products { get; private set; }
		public Order(Customer customer, Delivery delivery, ProductCollection products, TNumber number, string description)
		{
			Customer = customer;	
			Products = products;
			Delivery = (TDelivery)delivery;
			Number = number;
			Description = description;
		}

		public TDelivery Delivery { get; private set; }

		public TNumber Number { get; private set; }

		public string Description { get; private set; }

		
		public void DisplayAddress()
		{
			Console.WriteLine(Delivery.Address);
		}
	}
}
