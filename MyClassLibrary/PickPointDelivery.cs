namespace MyClassLibrary
{
	public class PickPointDelivery : Delivery
	{
		private ShopCompany shopCompany;
		public static string[] PickPointsAddresses = { "Address 1", "Address 2", "Address 3" };
		public PickPointDelivery(string address) : base(address)
		{
		}
		public override void Deliver()
		{
			for (int i = 0; i < PickPointsAddresses.Length; i++)
			{
				if (PickPointsAddresses[i] == Address)
				{
					shopCompany = new ShopCompany(new Contact("+7(910)..."));
					shopCompany.Deliver(Address);
				}
				else
					Console.WriteLine("Выберите другой пункт выдачи");
			}
		}
	}
}
