class Program
{
	public static void Main(String[] args)
	{
		for (int i = 1; i <= 8; i++)
		{
			for (int j = 0; j < i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
		Console.ReadLine();
	}
}