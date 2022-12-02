namespace MyClassLibrary
{
	public class ShopCompany : Company<Contact>
	{
		public ShopCompany(Contact contact) : base(contact)
		{
		}
		public override void Deliver(string address)
		{
			Console.WriteLine("Доставка в пункт выдачи по адресу: {0}", address);
		}
	}
}
