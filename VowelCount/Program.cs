using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string str = "Hello";

		var vowel = str.Where(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u');

		Console.WriteLine("Vowels are:{0}", vowel.Count());
	}
}