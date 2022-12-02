using MyClassLibrary;

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
			
			var order = new Order<HomeDelivery>(customer, new HomeDelivery(customer.productCollection, "Address"), customer.productCollection, 2345, "описание заказа");
			order.delivery.Deliver();
			
			var order1 = new Order<PickPointDelivery>(customer, new PickPointDelivery("Address 2"), customer.productCollection, 2346, "описание заказа 1");
			order1.delivery.Deliver();

			var order2 = new Order<ShopDelivery>(customer, new ShopDelivery("Address 15"), customer.productCollection, 2347, "описание заказа 2");
			order2.delivery.Deliver();

			
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}