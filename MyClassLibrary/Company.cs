namespace MyClassLibrary
{
	public abstract class Company
	{
		public Contact contact;
		public Company(Contact contact)
		{
			this.contact = contact;
		}
		public virtual void Deliver(string address)
		{
			Console.WriteLine("Доставка в розничный магазин по адресу: {0}", address);
		}
	}
}
