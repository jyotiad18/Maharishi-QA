using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(stantonMeasure(new int[] { 1 }));
		Console.WriteLine(stantonMeasure(new int[] { 1, 1, 2, 3, 4, 4, 4 }));
		Console.WriteLine(stantonMeasure(new int[] { 1, 1, 1, 3, 3, 3 }));
	}
	public static int stantonMeasure(int[] a)
	{
		int i = 0;
		int r = 0;

		foreach (int _a in a)
		{
			if (_a == 1) i++;
		}
		foreach (int _a in a)
		{
			if (_a == i) r++;
		}

		return r;
	}
}