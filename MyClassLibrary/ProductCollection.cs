namespace MyClassLibrary
{
	public class ProductCollection
	{
		public List<Product<string>> collection;   
		public ProductCollection(List<Product<string>> collection)
		{
			this.collection = collection;
		}
		public Product<string> this[int index]
		{
			get
			{
				if (index >= 0 && index < collection.Count)
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
				if (index >= 0 && index < collection.Count)
				{
					collection[index] = value;
				}
			}
		}
		public Product<string> this[string title]
		{
			get
			{
				for (int i = 0; i < collection.Count; i++)
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
