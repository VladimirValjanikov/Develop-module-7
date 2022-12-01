namespace MyClassLibrary
{
	public class CourierCollection
	{
		public static List<Courier> list;
		static CourierCollection()
		{
			list = new List<Courier>()
				{
					new Courier("Ivanov", new Contact("+7(980)...")),
					new Courier("Popov", new Contact("+7(920)...")),
					new Courier("Petrov", new Contact("+7(910)..."))
				};
		}		
	}
}
