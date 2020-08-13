using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(sumFactor(new int[] { 1 }));
		Console.WriteLine(sumFactor(new int[] { 3, 0, 0, -5, 2 }));
		Console.WriteLine(sumFactor(new int[] { 1, 1, 1, 3, 3, 3 }));
	}
	public static int sumFactor(int[] a)
	{
		int sum = 0;
		int count = 0;
		foreach (int _a in a)
		{
			sum += _a;
		}
		foreach (int _a in a)
		{
			if (sum == _a)
			{
				count++;
			}
		}
		return count;

	}
}