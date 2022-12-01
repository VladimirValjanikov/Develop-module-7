namespace MyClassLibrary
{
	public class Customer : Person
	{
		public List<Product> collection = new List<Product>();

        public Customer(string name, Contact contact) : base(name, contact)
		{
		}
		public ProductCollection BuyProduct(Product product)
		{
			collection.Add(product);
            var productCollection = new ProductCollection(collection);
            return productCollection;

            //Product[] products = new Product[0];			
            /*var productCollection = new ProductCollection(products);
			return productCollection;*/
        }
	}
}
