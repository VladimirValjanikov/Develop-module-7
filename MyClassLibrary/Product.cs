namespace MyClassLibrary
{
	public class Product
	{
		public string Title { get; private set; }
		public string Description { get; private set; }

		private const double discount = 0.1;
		public string SerialNumber { get; set; }
		public double DiscountPrice { get { return Price - Price * discount; } }

		private double price;
		public double Price
		{
			get
			{
				var dateTime = new DateTime();
				if (dateTime.DayOfWeek == DayOfWeek.Friday)
					return DiscountPrice;
				else return price;
			}
			private set
			{
				price = value;
			}
		}
		public double Weight { get; private set; }

		public Product(string title, string description, double price, double weight)
		{
			Title = title;
			Description = description;
			Price = price;
			Weight = weight;
		}
		public string GetDescription(string number)
		{
			Console.Write("Базовая логика получения серийного номера товара {0}: ", Title);
			SerialNumber = number;
			return SerialNumber;
		}
		public static bool operator == (Product a, Product b)
		{
			return a.Title == b.Title && a.Description == a.Description;
		}
		public static bool operator != (Product a, Product b)
		{
			return a.Title != b.Title || a.Description != a.Description;
		}
	}
}
