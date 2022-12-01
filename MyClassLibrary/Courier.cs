namespace MyClassLibrary
{
	public class Courier : Person
	{
		public Courier(string name, Contact contact) : base(name, contact)
		{
		}
		public void Deliver(string address)
		{
			Console.WriteLine("Доставка курьером по адресу: {0}", address);
		}
	}
}
