namespace MyClassLibrary
{
	public class Customer : Person
	{
		public Customer(string name, Contact contact) : base(name, contact)
		{
		}
		public ProductCollection BuyProduct(Product[] products)
		{
			var productCollection = new ProductCollection(products);
			return productCollection;
		}
	}
}
