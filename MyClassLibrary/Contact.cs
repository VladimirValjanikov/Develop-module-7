namespace MyClassLibrary
{
	public class Contact
	{
		public string PhoneNumber { get; private set; }
		public Contact(string phoneNumber)
		{
			PhoneNumber = phoneNumber;
		}
		public static void Call<T>(T person) where T : Person
		{
			Console.WriteLine("Звонок контакту {0} по номеру {1} ", person.Name , person.Contact.PhoneNumber);
		}
	}
}
