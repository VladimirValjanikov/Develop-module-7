namespace MyClassLibrary
{
	public static class MyExtension
	{
		public static string GetDescription(this Product<string> product, string number)
		{
			Console.WriteLine("Расширенная логика получения серийного номера товара: ", product.Title);
			product.SerialNumber = number + "1";
			return product.SerialNumber;
		}
	}
}
