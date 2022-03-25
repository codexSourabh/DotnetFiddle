using System;

public class Program
{
	public static void Main()
	{
		int num = 153;
		int sum = 0;
		int temp = num;

		while (num > 0)
		{
			int rem = num % 10;
			sum = sum + (rem * rem * rem);
			num = num / 10;
		}

		if (temp == sum)
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}