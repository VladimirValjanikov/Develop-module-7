using MyClassLibrary;

namespace Develop7_7
{
	internal class Program
	{						
		static void Main(string[] args)
		{
			var productJeans = new Product<string>("Джинсы", "Черные", 2000, 0.5);
            var productShirt = new Product<string>("Футболка", "Белая", 1500, 0.2);

			var customer = new Customer("Владимир", new Contact("+7(958)..."));
			
			customer.BuyProduct(productJeans);
			customer.BuyProduct(productShirt);
			
			var order = new Order<HomeDelivery, int>(customer, new HomeDelivery(customer.ProductCollection, "Address"), customer.ProductCollection, 2345, "описание заказа");
			order.Delivery.Deliver();
			
			var order1 = new Order<PickPointDelivery, string>(customer, new PickPointDelivery("Address 2"), customer.ProductCollection, "2345a", "описание заказа 1");
			order1.Delivery.Deliver();

			var order2 = new Order<ShopDelivery, string>(customer, new ShopDelivery("Address 15"), customer.ProductCollection, "2345b,", "описание заказа 2");
			order2.Delivery.Deliver();

			Contact.Call(customer);

			MyExtension.GetDescription(productJeans, "1");

			Console.WriteLine();
			Console.ReadLine();
		}
	}
}