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

            Console.Write(" ");

            for (int k = 0 ; k < i; k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}

        Console.ReadLine();

    }
}