using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(countSquarePairs(new int[] { 9, 7 }));
	}
	public static int countSquarePairs(int[] a)
	{
		int result = 0;
		if (a.Length <= 1) return result;
		Array.Sort(a);
		for (int i = 0; i < a.Length - 1; i++)
		{
			if (a[i] < 1)
			{
				continue;
			}
			for (int j = i + 1; j < a.Length; j++)
			{
				double sqrt = Math.Sqrt(a[i] + a[j]);
				if (sqrt * 10 % 10 == 0)
				{
					result++;
				}
			}
		}
		return result;
	}
}