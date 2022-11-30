using System;
using System.Collections.Generic;

namespace Develop7_7
{
	internal class Program
	{
		abstract class Delivery
		{
			public string Address { get; private set; }

			public Delivery(string address)
			{
				Address = address;
			}
			public abstract void Deliver();
		}
		abstract class Person
		{
			public string Name { get; private set; }
			public Contact contact;
			public Person(string name, Contact contact)
			{
				Name = name;
				this.contact = contact;
			}
		}
		class Contact
		{
			public string PhoneNumber { get; set; }
			public Contact(string phoneNumber)
			{
				PhoneNumber = phoneNumber;
			}
			public void Call()
			{
				Console.WriteLine("Звонить");
			}
		}
		static class CourierCollection
		{
			public static List<Courier> list;
			static CourierCollection()
			{
				list = new List<Courier>()
				{
					new Courier("Ivanov", new Contact("+7(980)...")),
					new Courier("Popov", new Contact("+7(920)...")),
					new Courier("Petrov", new Contact("+7(910)..."))
				};
			}
		}
		class Courier : Person
		{
			public Courier(string name, Contact contact) : base(name, contact)
			{
			}
			public void Deliver(string address)
			{
				Console.WriteLine("Доставка курьером по адресу: {0}", address);
			}
		}
		class Customer : Person
		{
			public Customer(string name, Contact contact) : base(name, contact)
			{
			}
			/*public void BuyProduct(Product )
			{
				Console.WriteLine("Доставка курьером по адресу: {0}", );
			}*/
		}
		abstract class Company
		{
			public Contact contact;
			public Company(Contact contact)
			{
				this.contact = contact;
			}
			public virtual void Deliver(string address)
			{
				Console.WriteLine("Доставка в розничный магазин по адресу: {0}", address);
			}
		}

		class ShopCompany : Company
		{
			public ShopCompany(Contact contact) : base(contact)
			{
			}
			public override void Deliver(string address)
			{
				Console.WriteLine("Доставка в пункт выдачи по адресу: {0}", address);
			}
		}
		class CourierCompany : Company
		{
			public CourierCompany(Contact contact) : base(contact)
			{
			}
			public override void Deliver(string address)
			{
				Console.WriteLine("Доставка курьерской компанией по адресу: {0}", address);
			}
		}
		class HomeDelivery : Delivery
		{
			public bool СourierDelivery { get; private set; }
			private Courier courier;
			private CourierCompany company;
			private ProductCollection products;
			private const double MaxWeights = 20;

			public HomeDelivery(ProductCollection products, string address) : base(address)
			{
				this.products = products;
				double sumWeights = 0.0;
				foreach (Product product in products.collection)
					sumWeights += product.Weight;
				if (sumWeights <= MaxWeights)
					СourierDelivery = true;
			}
			public override void Deliver()
			{
				if (СourierDelivery)
				{
					Random rand = new Random();
					CourierCollection.list[rand.Next(2)].Deliver(Address);
				}
				else
				{
					company = new CourierCompany(new Contact("+7(953)..."));
					company.Deliver(Address);
				}
			}
		}
		class PickPointDelivery : Delivery
		{
			private ShopCompany shopCompany;
			public static string[] PickPointsAddresses = { "Address 1", "Address 2", "Address 3" };
			public PickPointDelivery(string address) : base(address)
			{
			}
			public override void Deliver()
			{
				for (int i = 0; i < PickPointsAddresses.Length; i++)
				{
					if (PickPointsAddresses[i] == Address)
					{
						shopCompany = new ShopCompany(new Contact("+7(910)..."));
						shopCompany.Deliver(Address);
					}
					else
						Console.WriteLine("Выберите другой пункт выдачи");
				}
			}
		}
		class ShopDelivery : Delivery
		{
			private Company company;
			public ShopDelivery(string address) : base(address)
			{
			}
			public override void Deliver()
			{
				company.Deliver(Address);
			}
		}

		class Product
		{
			public string Title { get; private set; }
			public string Description { get; private set; }
			public double Price { get; private set; }
			public double Weight { get; private set; }
			public Product(string title, string description, double price, double weight)
			{
				Title = title;
				Description = description;
				Price = price;
				Weight = weight;
			}
		}
		class ProductCollection
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

		class Order<TDelivery, TClass>
		where TDelivery : Delivery
		where TClass : class
		{
			public ProductCollection products;
			public Order(Delivery delivery, Product[] products, int number, string description)
			{
				this.products = new ProductCollection(products);
				this.delivery = (TDelivery)delivery;
				Number = number;
				Description = description;
			}

			public TDelivery delivery;

			public int Number;

			public string Description;

			public void DisplayAddress()
			{
				Console.WriteLine(delivery.Address);
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}