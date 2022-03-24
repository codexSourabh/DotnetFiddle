using System;

public class Program
{
	static string sort(char[] arr)
	{
		for (int i = 0; i < arr.Length - 1; i++)
		{
			for (int j = 0; j < arr.Length - i - 1; j++)
			{
				if (arr[j] > arr[j + 1])
				{
					char temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
			}
		}
		string res = new string(arr);
		return res;
	}
	public static void Main()
	{
		string s1 = "dubai";
		string s2 = "iabud";

		string v1 = sort(s1.ToCharArray());
		string v2 = sort(s2.ToCharArray());

		Console.WriteLine(v1);
		Console.WriteLine(v2);

		if (v1 == v2)
		{
			Console.WriteLine("Yes");
		}
		else
		{
			Console.WriteLine("No");
		}


	}
}