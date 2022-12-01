namespace MyClassLibrary
{
	public class ProductCollection
	{
		public Product[] collection;

		public ProductCollection(Product[] collection)
		{
			this.collection = collection;
		}
		public Product this[int index]
		{
			get
			{
				if (index >= 0 && index < collection.Length)
				{
					return collection[index];
				}
				else
				{
					return null;
				}
			}
			private set
			{
				if (index >= 0 && index < collection.Length)
				{
					collection[index] = value;
				}
			}
		}
		public Product this[string title]
		{
			get
			{
				for (int i = 0; i < collection.Length; i++)
				{
					if (collection[i].Title == title)
					{
						return collection[i];
					}
				}
				return null;
			}
		}
	}
}
