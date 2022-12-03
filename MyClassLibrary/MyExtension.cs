namespace MyClassLibrary
{
	public static class MyExtension
	{
		public static string GetDescription(this Product product, string number)
		{
			Console.Write("Расширенная логика получения серийного номера товара {0}: ", product.Title);
			product.SerialNumber = number + "n";
			return product.SerialNumber;
		}
	}
}
