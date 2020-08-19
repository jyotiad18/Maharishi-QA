using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(repsEqual(new int[] { 3, 2, 0, 2, 3 }, 32023));
		Console.WriteLine(repsEqual(new int[] { 3, 2, 0, 2 }, 32023));
		Console.WriteLine(repsEqual(new int[] { 3, 2, 0, 9 }, 320));
	}
	public static int repsEqual(int[] a, int n)
	{
		int i = a.Length - 1;
		while (n != 0 || i >= 0)
		{
			int _n = n % 10;
			int _a = a[i];
			if (_n != _a) return 0;
			n /= 10;
			i--;
		}
		return 1;
	}
}