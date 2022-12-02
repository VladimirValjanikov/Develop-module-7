namespace MyClassLibrary
{
	public abstract class Person
	{
		public string Name { get; private set; }
		public Contact Contact { get; private set; }
		public Person(string name, Contact contact)
		{
			Name = name;
			Contact = contact;
		}
	}
}
