namespace MyClassLibrary
{
	public abstract class Person
	{
		public string Name { get; private set; }
		public Contact contact;
		public Person(string name, Contact contact)
		{
			Name = name;
			this.contact = contact;
		}
	}
}
