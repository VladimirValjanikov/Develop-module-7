namespace MyClassLibrary
{
	public abstract class Company
	{
		public Contact contact;
		public Company(Contact contact)
		{
			this.contact = contact;
		}
		public abstract void Deliver(string address);	
	}
}
