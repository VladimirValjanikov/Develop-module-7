namespace MyClassLibrary
{
	public abstract class Delivery
	{
		public string Address { get; private set; }

		public Delivery(string address)
		{
			Address = address;
		}
		public abstract void Deliver();
	}
}