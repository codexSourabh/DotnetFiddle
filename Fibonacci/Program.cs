using System;

public class Program
{
	static int fibo(int n)
	{
		if (n == 0)
			return 0;
		else if (n == 1)
			return 1;
		else
			return (fibo(n - 1) + fibo(n - 2));
	}

	public static void Main()
	{
		int num = 10;

		for (int i = 0; i < num; i++)
		{
			Console.WriteLine(fibo(i));
		}
	}
}