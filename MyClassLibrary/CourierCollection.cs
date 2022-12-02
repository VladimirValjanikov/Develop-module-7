namespace MyClassLibrary
{
	static class CourierCollection
	{
		public static List<Courier> ListCourier { get; private set; }
		static CourierCollection()
		{
			ListCourier = new List<Courier>()
				{
					new Courier("Ivanov", new Contact("+7(980)...")),
					new Courier("Popov", new Contact("+7(920)...")),
					new Courier("Petrov", new Contact("+7(910)..."))
				};
		}		
	}
}
