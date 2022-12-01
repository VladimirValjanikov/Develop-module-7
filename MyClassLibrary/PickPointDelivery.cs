namespace MyClassLibrary
{
	public class PickPointDelivery : Delivery
	{
		private readonly ShopCompany shopCompany;
		private static readonly string[] PickPointsAddresses = { "Address 1", "Address 2", "Address 3" };
		public PickPointDelivery(string address) : base(address)
		{
			shopCompany = new ShopCompany(new Contact("+7(910)..."));
		}
		public override void Deliver()
		{
			for (int i = 0; i < PickPointsAddresses.Length; i++)
			{
				if (PickPointsAddresses[i] == Address)									
					shopCompany.Deliver(Address);				
				else
					Console.WriteLine("Выберите другой пункт выдачи");
			}
		}
	}
}
