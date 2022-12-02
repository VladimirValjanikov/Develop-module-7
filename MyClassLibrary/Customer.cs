namespace MyClassLibrary
{
	public class Customer : Person
	{
		public List<Product> collection;
		public ProductCollection productCollection;
		public Customer(string name, Contact contact) : base(name, contact)
		{
			collection = new List<Product>();
			productCollection = new ProductCollection(collection);
		}
		public void BuyProduct(Product product)
		{
			collection.Add(product);
			productCollection.collection = collection;
        }
	}
}
