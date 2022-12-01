using MyClassLibrary;
using System.Diagnostics;

namespace Develop7_7
{
	internal class Program
	{						
		static void Main(string[] args)
		{
			var productJeans = new Product("Джинсы", "Черные", 2000, 0.5);
            var productShirt = new Product("Футболка", "Белая", 1500, 0.2);
			var customer = new Customer("Владимир", new Contact("+7(958)..."));
			customer.BuyProduct(productJeans);
            customer.BuyProduct(productShirt);
			customer.collection
            Console.WriteLine();
			Console.ReadLine();
		}
	}
}