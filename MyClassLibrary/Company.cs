namespace MyClassLibrary
{
	public abstract class Company<T>
	{
		protected T contact;
		public Company(T contact)
		{
			this.contact = contact;
		}
		public abstract void Deliver(string address);	
	}
}
