namespace MyClassLibrary
{
	public class Contact
	{
		public string PhoneNumber { get; set; }
		public Contact(string phoneNumber)
		{
			PhoneNumber = phoneNumber;
		}
		public void Call()
		{
			Console.WriteLine("Звонить");
		}
	}
}
