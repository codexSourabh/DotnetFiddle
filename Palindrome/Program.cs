using System;

public class Program
{
	public static void Main()
	{
		int num = 151;
		int temp = num;
		int sum = 0;

		while (num > 0)
		{
			int rem = num % 10;
			sum = (sum * 10) + rem;
			num = num / 10;
		}

		if (sum == temp)
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");

	}
}