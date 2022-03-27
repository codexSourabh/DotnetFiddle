using System;

public class Program
{
	static int facto(int n)
	{
		if (n == 0)
			return 1;
		else
			return (n * (facto(n - 1)));
	}

	public static void Main()
	{
		int num = 5;

		Console.WriteLine(facto(num));
	}
}