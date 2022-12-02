namespace MyClassLibrary
{
	public class Customer : Person
	{
		public List<Product<string>> Collection { get; private set; }
		public ProductCollection ProductCollection { get; private set; }
		public Customer(string name, Contact contact) : base(name, contact)
		{
			Collection = new List<Product<string>>();
			ProductCollection = new ProductCollection(Collection);
		}
		public void BuyProduct(Product<string> product)
		{
			Collection.Add(product);
			ProductCollection.collection = Collection;
        }
	}
}
