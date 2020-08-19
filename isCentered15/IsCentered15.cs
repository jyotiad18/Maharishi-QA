using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(isCentered15(new int[] { 3, 2, 0, 2, 3 }));
		Console.WriteLine(isCentered15(new int[] { 3, 2, 10, 4, 1, 6, 9 }));
	}
	public static int isCentered15(int[] a)
	{
		for (int i = 0; 2 * i < a.Length; i++)
		{
			int sum = 0;
			for (int index = i; index < a.Length - i; index++)
			{
				sum += a[index];
			}
			if (sum == 15)
			{
				return 1;
			}
		}
		return 0;
	}
}