using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(isGuthrieSequence(new int[] { 8, 17, 4, 2 }));
	}
	public static int isGuthrieSequence(int[] a)
	{
		if (a[a.Length - 1] != 1)
		{
			return 0;
		}
		for (int i = 0; i < a.Length - 1; i++)
		{
			if (a[i] % 2 == 0)
			{
				if (a[i] / 2 != a[i + 1])
				{
					return 0;
				}
			}
			else
			{
				if (a[i] * 3 + 1 != a[i + 1])
				{
					return 0;
				}
			}
		}
		return 1;
	}
}