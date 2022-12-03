namespace MyClassLibrary
{
	public class ProductCollection
	{
		public List<Product> collection;   
		public ProductCollection(List<Product> collection)
		{
			this.collection = collection;
		}
		public Product this[int index]
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
		public Product this[string title]
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
