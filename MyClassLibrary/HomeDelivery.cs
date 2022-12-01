namespace MyClassLibrary
{
	public class HomeDelivery : Delivery
	{
		public bool СourierDelivery { get; private set; }
		private CourierCompany company;
		private ProductCollection products;
		private const double MaxWeights = 20;

		public HomeDelivery(ProductCollection products, string address) : base(address)
		{
			this.products = products;
			double sumWeights = 0.0;
			foreach (Product product in this.products.collection)
				sumWeights += product.Weight;
			if (sumWeights <= MaxWeights)
				СourierDelivery = true;
		}
		public override void Deliver()
		{
			if (СourierDelivery)
			{
				Random rand = new Random();
				CourierCollection.list[rand.Next(2)].Deliver(Address);
			}
			else
			{
				company = new CourierCompany(new Contact("+7(953)..."));
				company.Deliver(Address);
			}
		}
	}
}
