namespace MyClassLibrary
{
	public class CourierCompany : Company
	{		
		public CourierCompany(Contact contact) : base(contact)
		{			
		}
		public override void Deliver(string address)
		{
			Console.WriteLine("Доставка курьерской компанией по адресу: {0}", address);
		}
	}
}
